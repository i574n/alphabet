#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_b8cdef03 {
    pub mod Documents {
        use super::*;
        use fable_library_rust::Async_::Async;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith3;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::indexOf;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
        use fable_library_rust::String_::trim;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Text::StringBuilder;
        use fable_library_rust::System::Threading::CancellationToken;
        type TaskCanceledException = ();
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        LrcPtr<Documents::Mut3>,
                        LrcPtr<Documents::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        pub trait IFs: core::fmt::Debug + core::fmt::Display {
            fn realpathSync(&self, path: string) -> string;
        }
        impl<V: IFs + core::fmt::Debug + core::fmt::Display> IFs for LrcPtr<V> {
            #[inline]
            fn realpathSync(&self, path: string) -> string {
                (**self).realpathSync(path)
            }
        }
        pub trait IPathJoin: core::fmt::Debug + core::fmt::Display {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + core::fmt::Debug + core::fmt::Display> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync: core::fmt::Debug + core::fmt::Display {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + core::fmt::Debug + core::fmt::Display> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname: core::fmt::Debug + core::fmt::Display {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + core::fmt::Debug + core::fmt::Display> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        pub trait IPathBasename: core::fmt::Debug + core::fmt::Display {
            fn basename(&self, path: string) -> string;
        }
        impl<V: IPathBasename + core::fmt::Debug + core::fmt::Display> IPathBasename for LrcPtr<V> {
            #[inline]
            fn basename(&self, path: string) -> string {
                (**self).basename(path)
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Documents::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Documents::US0),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(Documents::US3),
            US4_1(Documents::US3),
            US4_2(Documents::US3),
            US4_3(Documents::US3),
            US4_4(Documents::US3),
            US4_5(Documents::US3),
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0,
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(string),
            US8_1(string),
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::path::PathBuf),
            US9_1(string),
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(std::path::PathBuf),
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(std::fs::FileType),
            US11_1(std::string::String),
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US12 {
            US12_0,
            US12_1,
            US12_2,
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(async_walkdir::DirEntry),
            US13_1(std::string::String),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US14 {
            US14_0(string, Documents::US5),
            US14_1(string),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Documents::UH0>),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US15>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
        }
        impl core::fmt::Display for US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US17 {
            US17_0(char),
            US17_1,
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(string, LrcPtr<StringBuilder>, i32, i32),
            US18_1(string),
        }
        impl core::fmt::Display for US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(
                string,
                Documents::US5,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US19_1(string),
        }
        impl core::fmt::Display for US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(Documents::US17, string, LrcPtr<StringBuilder>, i32, i32),
            US20_1(string),
        }
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Documents::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US21_1(string),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US22 {
            US22_0(Array<string>),
            US22_1(string),
        }
        impl core::fmt::Display for US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Documents::UH2>),
        }
        impl core::fmt::Display for UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(
                LrcPtr<Documents::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US23_1(string),
        }
        impl core::fmt::Display for US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US16>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US24_1(std::string::String),
        }
        impl core::fmt::Display for US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US25_1,
        }
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(std::string::String),
            US26_1(std::string::String),
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US27_1,
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US28_1,
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(std::process::Output),
            US29_1(std::string::String),
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US30 {
            US30_0(i32),
            US30_1,
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US31_1,
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US32 {
            US32_0(CancellationToken),
            US32_1,
        }
        impl core::fmt::Display for US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US33 {
            US33_0(Result<string, LrcPtr<(string, string)>>),
            US33_1,
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH5 {
            UH5_0,
            UH5_1(
                string,
                string,
                Func2<string, string, Documents::US33>,
                LrcPtr<Documents::UH5>,
            ),
        }
        impl core::fmt::Display for UH5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(LrcPtr<Documents::UH5>, LrcPtr<Documents::UH4>),
        }
        impl core::fmt::Display for UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(string),
            US34_1(std::string::String),
        }
        impl core::fmt::Display for US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(u64),
            US35_1(std::string::String),
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US36 {
            US36_0(i32, string),
            US36_1(i32, string),
        }
        impl core::fmt::Display for US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut8 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<i32>,
            pub l3: MutCell<i32>,
        }
        impl core::fmt::Display for Mut8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
            ),
            US37_1(std::string::String),
        }
        impl core::fmt::Display for US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"source-dir\"#");
            let v7: &'static str = r#"source-dir"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('s');
            let v12: string = string("r#\"source-dir\"#");
            let v13: &'static str = r#"source-dir"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            let v19: clap::Command = clap::Command::arg(v4, v17);
            let v21: string = string("r#\"dist-dir\"#");
            let v22: &'static str = r#"dist-dir"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('d');
            let v27: string = string("r#\"dist-dir\"#");
            let v28: &'static str = r#"dist-dir"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            let v34: clap::Command = clap::Command::arg(v19, v32);
            let v36: string = string("r#\"cache-dir\"#");
            let v37: &'static str = r#"cache-dir"#;
            let v39: clap::Arg = clap::Arg::new(v37);
            let v41: clap::Arg = v39.short('c');
            let v42: string = string("r#\"cache-dir\"#");
            let v43: &'static str = r#"cache-dir"#;
            let v45: clap::Arg = v41.long(v43);
            let v47: clap::Arg = v45.required(true);
            let v49: clap::Command = clap::Command::arg(v34, v47);
            let v51: string = string("r#\"hangul-spec\"#");
            let v52: &'static str = r#"hangul-spec"#;
            let v54: clap::Arg = clap::Arg::new(v52);
            let v56: clap::Arg = v54.short('h');
            let v57: string = string("r#\"hangul-spec\"#");
            let v58: &'static str = r#"hangul-spec"#;
            let v60: clap::Arg = v56.long(v58);
            let v62: clap::Arg = v60.required(true);
            clap::Command::arg(v49, v62)
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1_1: bool = true;
            () //;
        } /* /*;
          {
              let v4: string = string("*/ #[test] fn verify_app() { //");
              let v5: bool = */
        #[test]
        fn verify_app() {
            //;
            let v6: clap::Command = Documents::method0();
            clap::Command::debug_assert(v6);
            {
                //;
                ()
            }
        }
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Documents::US5> {
            Func1::new(move |v: string| Documents::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
            let v6: string = Documents::method4(v0_1);
            let v8: Result<std::string::String, std::env::VarError> = std::env::var(&*v6);
            let v10: bool = true;
            let _result_map_ = v8.map(|x| {
                //;
                let v12: std::string::String = x;
                let v14: string = fable_library_rust::String_::fromString(v12);
                let v16: bool = true;
                v14
            });
            let v18: Result<string, std::env::VarError> = _result_map_;
            let v19: string = Documents::method5();
            v18.unwrap_or(v19)
        }
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v6 {
                    Documents::US1::US1_0(v6_0_0) => Documents::US1::US1_0(
                        match &v6 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v13 {
                            Documents::US1::US1_0(v13_0_0) => Documents::US1::US1_0(
                                match &v13 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v20 {
                                    Documents::US1::US1_0(v20_0_0) => Documents::US1::US1_0(
                                        match &v20 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v27: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v27 {
                                            Documents::US1::US1_0(v27_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v27 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v34: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Documents::US1::US1_0(v34_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v34 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => Documents::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Documents::method3(string("AUTOMATION"))) != string("True") {
                    Documents::US2::US2_1
                } else {
                    Documents::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Documents::US0,
        ) -> (
            LrcPtr<Documents::Mut0>,
            LrcPtr<Documents::Mut1>,
            LrcPtr<Documents::Mut2>,
            LrcPtr<Documents::Mut3>,
            LrcPtr<Documents::Mut4>,
            Option<i64>,
        ) {
            let patternInput: (Documents::US1, Documents::US2) = Documents::method2();
            let _run_target_args__v3: (Documents::US1, Documents::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v173: Documents::US2 = _run_target_args__v3.1.clone();
            let v172: Documents::US1 = _run_target_args__v3.0.clone();
            (
                LrcPtr::new(Documents::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Documents::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure4((), v))),
                }),
                LrcPtr::new(Documents::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(match &v172 {
                        Documents::US1::US1_0(v172_0_0) => match &v172 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v173 {
                    Documents::US2::US2_0(v173_0_0) => Some(match &v173 {
                        Documents::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_2);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_0);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn method7(v0_1: Documents::US0) -> bool {
            let v3: () = {
                Documents::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v42: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v42,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method9() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure7((), v))
        }
        pub fn method10() -> string {
            string("hh:mm:ss")
        }
        pub fn method11() -> string {
            string("HH:mm:ss")
        }
        pub fn method8(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v182: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method9(), v5));
            let v300: DateTime = match &v182 {
                Documents::US2::US2_0(v182_0_0) => {
                    let v252: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v182 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v252.hours(),
                        v252.minutes(),
                        v252.seconds(),
                        v252.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v302: string = Documents::method10();
            let provider: string = if (v302.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v302
            };
            v300.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v3);
            ()
        }
        pub fn method13(v0_1: char) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method15() -> string {
            string("\u{001b}[0m")
        }
        pub fn method12() -> string {
            let v7: string = Documents::method13(getCharAt(toLower(string("Info")), 0_i32));
            let v14: &str = inline_colorization::color_bright_green;
            let v21: &str = &*v7;
            let v49: &str = inline_colorization::color_reset;
            let v51: std::string::String = format!("{}{}{}", v14, v21, v49);
            fable_library_rust::String_::fromString(v51)
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v2.clone(), string("args"), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v53: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method18(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method16(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Array<string>,
        ) -> string {
            let v9: string = Documents::method17(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure9(v0_1: LrcPtr<Documents::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v3: () = {
                Documents::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn method19(v0_1: string) {
            let v3: () = {
                Documents::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v44: () = {
                Documents::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method16(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method12(),
                    v0_1,
                ))
            };
        }
        pub fn method20() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn method21() -> Func1<std::string::String, Documents::US6> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method22() -> string {
            string("dist-dir")
        }
        pub fn method23() -> string {
            string("cache-dir")
        }
        pub fn method24() -> string {
            string("hangul-spec")
        }
        pub fn method26() -> string {
            let v6: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v10: std::path::PathBuf = v6.unwrap();
            let v28: std::path::Display = v10.display();
            let v61: std::string::String = format!("{}", v28);
            fable_library_rust::String_::fromString(v61)
        }
        pub fn method28(v0_1: string, v1_1: string) -> string {
            let v13: &str = &*v0_1;
            let v46: std::string::String = String::from(v13);
            let v79: std::path::PathBuf = std::path::PathBuf::from(v46);
            let v112: &str = &*v1_1;
            let v145: std::string::String = String::from(v112);
            let v173: std::path::PathBuf = v79.join(v145);
            let v180: std::path::Display = v173.display();
            let v213: std::string::String = format!("{}", v180);
            fable_library_rust::String_::fromString(v213)
        }
        pub fn method30(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v99: std::path::PathBuf = std::path::PathBuf::from(v45);
            if v99.clone().exists() {
                v99.is_file()
            } else {
                false
            }
        }
        pub fn closure13(unitVar: (), v0_1: string) -> bool {
            Documents::method30(v0_1)
        }
        pub fn method31(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v99: std::path::PathBuf = std::path::PathBuf::from(v45);
            if v99.clone().exists() {
                v99.is_dir()
            } else {
                false
            }
        }
        pub fn closure14(unitVar: (), v0_1: string) -> bool {
            Documents::method31(v0_1)
        }
        pub fn method33(v0_1: string) -> Option<string> {
            let v9: &str = &*v0_1;
            let v42: std::string::String = String::from(v9);
            let v75: std::path::PathBuf = std::path::PathBuf::from(v42);
            let v103: Option<std::path::PathBuf> = v75.parent().map(std::path::PathBuf::from);
            let v105: bool = true;
            let _optionm_map_ = v103.map(|x| {
                //;
                let v107: std::path::PathBuf = x;
                let v114: std::path::Display = v107.display();
                let v147: std::string::String = format!("{}", v114);
                let v175: string = fable_library_rust::String_::fromString(v147);
                let v177: bool = true;
                v175
            });
            _optionm_map_
        }
        pub fn method34(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
            v4: string,
        ) -> Documents::US8 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<bool> = MutCell::new(v2);
            let v3 = MutCell::new(v3.clone());
            let v4: MutCell<string> = MutCell::new(v4.clone());
            '_method34: loop {
                break '_method34 (if v3(Documents::method28(v4.get().clone(), v0_1.get().clone())) {
                    Documents::US8::US8_0(v4.get().clone())
                } else {
                    let v8: Option<string> = Documents::method33(v4.get().clone());
                    let v25: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v8));
                    match &v25 {
                        Documents::US5::US5_0(v25_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: bool = v2.get().clone();
                            let v3_temp = v3.get().clone();
                            let v4_temp: string = match &v25 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method34;
                        }
                        _ => Documents::US8::US8_1(append(
                            (concat(new_array(&[
                                string("file_system.find_parent / No parent for "),
                                if v2.get().clone() {
                                    string("file")
                                } else {
                                    string("dir")
                                },
                            ]))),
                            sprintf!(
                                " \'{}\' at \'{}\' (until \'{}\')",
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v4.get().clone()
                            ),
                        )),
                    }
                });
            }
        }
        pub fn method32(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
        ) -> Documents::US8 {
            if v3(Documents::method28(v1_1.clone(), v0_1.clone())) {
                Documents::US8::US8_0(v1_1.clone())
            } else {
                let v7: Option<string> = Documents::method33(v1_1.clone());
                let v24: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v24 {
                    Documents::US5::US5_0(v24_0_0) => Documents::method34(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2,
                        v3.clone(),
                        match &v24 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => Documents::US8::US8_1(append(
                        (concat(new_array(&[
                            string("file_system.find_parent / No parent for "),
                            if v2 { string("file") } else { string("dir") },
                        ]))),
                        sprintf!(
                            " \'{}\' at \'{}\' (until \'{}\')",
                            v0_1.clone(),
                            v1_1.clone(),
                            v1_1.clone()
                        ),
                    )),
                }
            }
        }
        pub fn method29(v0_1: Documents::US7, v1_1: string, v2: string) -> Documents::US8 {
            let v3: bool = if let Documents::US7::US7_0 = &v0_1 {
                true
            } else {
                false
            };
            Documents::method32(
                v1_1,
                v2,
                v3,
                if v3 {
                    Func1::new(move |v: string| Documents::closure13((), v))
                } else {
                    Func1::new(move |v_1: string| Documents::closure14((), v_1))
                },
            )
        }
        pub fn method35() -> string {
            let v7: string = Documents::method13(getCharAt(toLower(string("Warning")), 0_i32));
            let v14: &str = inline_colorization::color_yellow;
            let v21: &str = &*v7;
            let v49: &str = inline_colorization::color_reset;
            let v51: std::string::String = format!("{}{}{}", v14, v21, v49);
            fable_library_rust::String_::fromString(v51)
        }
        pub fn method37(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v3.clone(), string("dir"), ());
                ()
            };
            let v31: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v40: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v50: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v60: () = {
                Documents::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v78: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v88: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method36(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Documents::method37(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v10
            ))
        }
        pub fn closure15(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v6: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method36(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method35(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method42(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: std::string::String = format!("{:#?}", v0_1);
            let v48: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v9), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method42(v0_1)
        }
        pub fn method41() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure16((), v))
        }
        pub fn closure17(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method43() -> Func1<std::path::PathBuf, Documents::US9> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: string) -> Documents::US9 {
            Documents::US9::US9_1(v0_1)
        }
        pub fn method44() -> Func1<string, Documents::US9> {
            Func1::new(move |v: string| Documents::closure18((), v))
        }
        pub fn method47(v0_1: string) -> string {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v78: std::path::PathBuf = std::path::PathBuf::from(v45);
            let v106: Option<&std::ffi::OsStr> = v78.file_name();
            let v108: bool = true;
            let _optionm_map_ = v106.map(|x| {
                //;
                let v110: &std::ffi::OsStr = x;
                let v112: std::ffi::OsString = v110.to_os_string();
                let v114: Option<&str> = v112.to_str();
                let v116: &str = v114.unwrap();
                let v123: std::string::String = String::from(v116);
                let v151: string = fable_library_rust::String_::fromString(v123);
                let v153: bool = true;
                v151
            });
            let v155: Option<string> = _optionm_map_;
            let v172: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v155));
            match &v172 {
                Documents::US5::US5_0(v172_0_0) => match &v172 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method48(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method46(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method47(v4.clone());
            let v6: Option<string> = Documents::method33(v4.clone());
            let v23: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v27: string = Documents::method48(v3);
            if (v2) >= 11_u8 {
                let v31: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v38: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v31);
                Err(v38)
            } else {
                if let Documents::US5::US5_0(v23_0_0) = &v23 {
                    if (v4.clone()) != string("") {
                        let v89: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v23_0_0.clone());
                        let v90 = Documents::method41();
                        let v103: Result<std::path::PathBuf, string> = v89.map_err(|x| v90(x));
                        let v106 = Documents::method43();
                        let v107 = Documents::method44();
                        let v108: Documents::US9 = match &v103 {
                            Err(v103_1_0) => v107(v103_1_0.clone()),
                            Ok(v103_0_0) => v106(v103_0_0.clone()),
                        };
                        match &v108 {
                            Documents::US9::US9_0(v108_0_0) => {
                                let v147: string = Documents::method28(
                                    toString(v108_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v154: &str = &*v147;
                                let v187: std::string::String = String::from(v154);
                                let v220: std::path::PathBuf = std::path::PathBuf::from(v187);
                                Ok(v220)
                            }
                            Documents::US9::US9_1(v108_1_0) => {
                                let v265: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v108_1_0.clone(),
                                        v27.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v272: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v265);
                                Err(v272)
                            }
                        }
                    } else {
                        let v318: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v27.clone(),
                                            v4.clone(), v5.clone()));
                        let v325: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v318);
                        Err(v325)
                    }
                } else {
                    let v370: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1, v27.clone(), v4, v5.clone()));
                    let v377: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v370);
                    Err(v377)
                }
            }
        }
        pub fn method45(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v9: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v10 = Documents::method41();
            let v23: Result<std::path::PathBuf, string> = v9.map_err(|x| v10(x));
            let v26 = Documents::method43();
            let v27 = Documents::method44();
            let v28: Documents::US9 = match &v23 {
                Err(v23_1_0) => v27(v23_1_0.clone()),
                Ok(v23_0_0) => v26(v23_0_0.clone()),
            };
            match &v28 {
                Documents::US9::US9_0(v28_0_0) => Ok(v28_0_0.clone()),
                Documents::US9::US9_1(v28_1_0) => Documents::method46(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v28_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure20(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method45(v0_1, v1_1, v2)
        }
        pub fn closure19(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure20(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method49(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method47(v0_1.clone());
            let v5: Option<string> = Documents::method33(v0_1.clone());
            let v22: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v26: string = Documents::method48(v3);
            if (v2) >= 11_u8 {
                let v30: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v37: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v30);
                Err(v37)
            } else {
                if let Documents::US5::US5_0(v22_0_0) = &v22 {
                    if (v0_1.clone()) != string("") {
                        let v88: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v22_0_0.clone());
                        let v89 = Documents::method41();
                        let v102: Result<std::path::PathBuf, string> = v88.map_err(|x| v89(x));
                        let v105 = Documents::method43();
                        let v106 = Documents::method44();
                        let v107: Documents::US9 = match &v102 {
                            Err(v102_1_0) => v106(v102_1_0.clone()),
                            Ok(v102_0_0) => v105(v102_0_0.clone()),
                        };
                        match &v107 {
                            Documents::US9::US9_0(v107_0_0) => {
                                let v146: string = Documents::method28(
                                    toString(v107_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v153: &str = &*v146;
                                let v186: std::string::String = String::from(v153);
                                let v219: std::path::PathBuf = std::path::PathBuf::from(v186);
                                Ok(v219)
                            }
                            Documents::US9::US9_1(v107_1_0) => {
                                let v264: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v107_1_0.clone(),
                                        v26.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v271: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v264);
                                Err(v271)
                            }
                        }
                    } else {
                        let v317: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v26.clone(),
                                            v0_1.clone(), v4.clone()));
                        let v324: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v317);
                        Err(v324)
                    }
                } else {
                    let v369: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v26.clone(), v0_1,
                                        v4.clone()));
                    let v376: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v369);
                    Err(v376)
                }
            }
        }
        pub fn method40(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v8: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v9 = Documents::method41();
            let v22: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
            let v25 = Documents::method43();
            let v26 = Documents::method44();
            let v27: Documents::US9 = match &v22 {
                Err(v22_1_0) => v26(v22_1_0.clone()),
                Ok(v22_0_0) => v25(v22_0_0.clone()),
            };
            match &v27 {
                Documents::US9::US9_0(v27_0_0) => Ok(v27_0_0.clone()),
                Documents::US9::US9_1(v27_1_0) => Documents::method49(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v27_1_0.clone(),
                ),
            }
        }
        pub fn method51(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method52() -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method53(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method55(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method47(v4.clone());
            let v6: Option<string> = Documents::method33(v4.clone());
            let v23: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v27: string = Documents::method42(v3);
            if (v2) >= 11_u8 {
                let v31: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v38: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v31);
                Err(v38)
            } else {
                if let Documents::US5::US5_0(v23_0_0) = &v23 {
                    if (v4.clone()) != string("") {
                        let v89: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v23_0_0.clone());
                        let v90 = Documents::method41();
                        let v103: Result<std::path::PathBuf, string> = v89.map_err(|x| v90(x));
                        let v106 = Documents::method43();
                        let v107 = Documents::method44();
                        let v108: Documents::US9 = match &v103 {
                            Err(v103_1_0) => v107(v103_1_0.clone()),
                            Ok(v103_0_0) => v106(v103_0_0.clone()),
                        };
                        match &v108 {
                            Documents::US9::US9_0(v108_0_0) => {
                                let v147: string = Documents::method28(
                                    toString(v108_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v154: &str = &*v147;
                                let v187: std::string::String = String::from(v154);
                                let v220: std::path::PathBuf = std::path::PathBuf::from(v187);
                                Ok(v220)
                            }
                            Documents::US9::US9_1(v108_1_0) => {
                                let v265: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v108_1_0.clone(),
                                        v27.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v272: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v265);
                                Err(v272)
                            }
                        }
                    } else {
                        let v318: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v27.clone(),
                                            v4.clone(), v5.clone()));
                        let v325: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v318);
                        Err(v325)
                    }
                } else {
                    let v370: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1, v27.clone(), v4, v5.clone()));
                    let v377: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v370);
                    Err(v377)
                }
            }
        }
        pub fn method54(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v42: i32 =
                Documents::method51(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v44: bool = Documents::method53(Documents::method52(), v42);
            if v44 {
                let v51: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v122: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v122)
            } else {
                let v144: string =
                    append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                    v0_1.clone(), v44, v2.clone(), v1_1));
                Documents::method55(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure21(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v144),
                    v2,
                )
            }
        }
        pub fn closure22(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method54(v0_1, v1_1, v2)
        }
        pub fn closure21(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure22(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method56(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method47(v0_1.clone());
            let v5: Option<string> = Documents::method33(v0_1.clone());
            let v22: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v26: string = Documents::method42(v3);
            if (v2) >= 11_u8 {
                let v30: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v37: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v30);
                Err(v37)
            } else {
                if let Documents::US5::US5_0(v22_0_0) = &v22 {
                    if (v0_1.clone()) != string("") {
                        let v88: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v22_0_0.clone());
                        let v89 = Documents::method41();
                        let v102: Result<std::path::PathBuf, string> = v88.map_err(|x| v89(x));
                        let v105 = Documents::method43();
                        let v106 = Documents::method44();
                        let v107: Documents::US9 = match &v102 {
                            Err(v102_1_0) => v106(v102_1_0.clone()),
                            Ok(v102_0_0) => v105(v102_0_0.clone()),
                        };
                        match &v107 {
                            Documents::US9::US9_0(v107_0_0) => {
                                let v146: string = Documents::method28(
                                    toString(v107_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v153: &str = &*v146;
                                let v186: std::string::String = String::from(v153);
                                let v219: std::path::PathBuf = std::path::PathBuf::from(v186);
                                Ok(v219)
                            }
                            Documents::US9::US9_1(v107_1_0) => {
                                let v264: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v107_1_0.clone(),
                                        v26.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v271: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v264);
                                Err(v271)
                            }
                        }
                    } else {
                        let v317: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v26.clone(),
                                            v0_1.clone(), v4.clone()));
                        let v324: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v317);
                        Err(v324)
                    }
                } else {
                    let v369: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v26.clone(), v0_1,
                                        v4.clone()));
                    let v376: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v369);
                    Err(v376)
                }
            }
        }
        pub fn method50(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v41: i32 =
                Documents::method51(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v43: bool = Documents::method53(Documents::method52(), v41);
            if v43 {
                let v50: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v121: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v121)
            } else {
                let v143: string =
                    append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                    v0_1.clone(), v43, v0_1.clone(), v1_1));
                Documents::method56(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure21(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v143),
                )
            }
        }
        pub fn method39(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method31(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method40(v0_1, 0_u8)
            }
        }
        pub fn closure23(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method57() -> Func1<std::path::PathBuf, Documents::US10> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure23((), v))
        }
        pub fn method59(v0_1: string) -> string {
            v0_1
        }
        pub fn method60() -> string {
            string("")
        }
        pub fn method58(v0_1: string, v1_1: string, v2: string) -> string {
            let v6: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v10: regex::Regex = v6.unwrap();
            let v22: string = Documents::method59(v2);
            let v24: std::borrow::Cow<str> = v10.replace_all(&*v22, &*v1_1);
            let v26: std::string::String = String::from(v24);
            fable_library_rust::String_::fromString(v26)
        }
        pub fn method38(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method39(v0_1.clone());
                let v7: Option<std::path::PathBuf> = v3.ok();
                let v35: Documents::US10 =
                    defaultValue(Documents::US10::US10_1, map(Documents::method57(), v7));
                let v78: string = match &v35 {
                    Documents::US10::US10_0(v35_0_0) => toString(
                        match &v35 {
                            Documents::US10::US10_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone()
                        .display(),
                    ),
                    _ => v0_1.clone(),
                };
                let v83: string = Documents::method58(
                    string("^\\\\\\\\\\?\\\\"),
                    string(""),
                    if (v78.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v78
                    },
                );
                if (length(v83.clone())) < 2_i32 {
                    v0_1.clone()
                } else {
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v83.clone(), 0_i32))),
                            getSlice(v83, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method27(v0_1: string) -> Documents::US5 {
            let v5: Documents::US8 = Documents::method29(
                Documents::US7::US7_1,
                Documents::method28(string("spiral"), string("workspace")),
                v0_1.clone(),
            );
            match &v5 {
                Documents::US8::US8_0(v5_0_0) => {
                    Documents::US5::US5_0(Documents::method38(v5_0_0.clone()))
                }
                Documents::US8::US8_1(v5_1_0) => {
                    let v12: () = {
                        Documents::closure15(v0_1.clone(), v5_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            }
        }
        pub fn method62(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method63(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method64() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method65(v0_1: string) -> string {
            v0_1
        }
        pub fn method61(v0_1: string) -> string {
            let v12: &str = &*v0_1.clone();
            let v45: std::string::String = String::from(v12);
            let v78: std::path::PathBuf = std::path::PathBuf::from(v45);
            if (v78.exists()) == false {
                let v108: string = Documents::method26();
                let v113: Array<string> = split(
                    Documents::method38(Documents::method28(v108.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v117: i32 = get_Count(v113.clone());
                let v118: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method62(v117, v118.clone()) {
                    let v120: i32 = v118.l0.get().clone();
                    let v123: i32 = ((v120.wrapping_neg()) + (v117)) - 1_i32;
                    let matchValue: i32 = v118.l1.get().clone();
                    let v125: Array<string> = v118.l2.get().clone();
                    let v124: i32 = matchValue;
                    let v126: string = v113[v123].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v126.clone()) {
                        ((v124) + 1_i32, v125.clone())
                    } else {
                        if string(".") == (v126.clone()) {
                            (v124, v125.clone())
                        } else {
                            if 0_i32 == (v124) {
                                if endsWith3(v126.clone(), string(":"), false) {
                                    let v137: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v108.clone(), 0_i32)
                                    )]);
                                    let v138: i32 = get_Count(v137.clone());
                                    let v140: i32 = (v138) + (get_Count(v125.clone()));
                                    let v141: Array<string> = new_init(&string(""), v140);
                                    let v142: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method63(v140, v142.clone()) {
                                        let v144: i32 = v142.l0.get().clone();
                                        let v149: string = if (v144) < (v138) {
                                            v137[v144].clone()
                                        } else {
                                            let v147: i32 = (v144) - (v138);
                                            v125[v147].clone()
                                        };
                                        v141.get_mut()[v144 as usize] = v149;
                                        {
                                            let v150: i32 = (v144) + 1_i32;
                                            v142.l0.set(v150);
                                            ()
                                        }
                                    }
                                    (0_i32, v141.clone())
                                } else {
                                    let v151: Array<string> = new_array(&[v126]);
                                    let v152: i32 = get_Count(v151.clone());
                                    let v154: i32 = (v152) + (get_Count(v125.clone()));
                                    let v155: Array<string> = new_init(&string(""), v154);
                                    let v156: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method63(v154, v156.clone()) {
                                        let v158: i32 = v156.l0.get().clone();
                                        let v163: string = if (v158) < (v152) {
                                            v151[v158].clone()
                                        } else {
                                            let v161: i32 = (v158) - (v152);
                                            v125[v161].clone()
                                        };
                                        v155.get_mut()[v158 as usize] = v163;
                                        {
                                            let v164: i32 = (v158) + 1_i32;
                                            v156.l0.set(v164);
                                            ()
                                        }
                                    }
                                    (0_i32, v155.clone())
                                }
                            } else {
                                ((v124) - 1_i32, v125.clone())
                            }
                        }
                    };
                    let v174: i32 = (v120) + 1_i32;
                    v118.l0.set(v174);
                    v118.l1.set(patternInput_1.0.clone());
                    v118.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v118.l1.get().clone();
                    let v176: Array<string> = v118.l2.get().clone();
                    let _let__v180: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v176 = v176.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v176 = v176.clone();
                                    move |i: i32| v176[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v176.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v192: string = ofChar(Documents::method64());
                    join(
                        if (v192.clone()) == string("\n") {
                            Documents::method65(v192.clone())
                        } else {
                            v192
                        },
                        toArray_1(_let__v180),
                    )
                }
            } else {
                let v205: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v209: std::path::PathBuf = v205.unwrap();
                let v227: std::path::Display = v209.display();
                let v260: std::string::String = format!("{}", v227);
                fable_library_rust::String_::fromString(v260)
            }
        }
        pub fn method66() -> string {
            let v7: string = Documents::method13(getCharAt(toLower(string("Debug")), 0_i32));
            let v14: &str = inline_colorization::color_bright_blue;
            let v21: &str = &*v7;
            let v49: &str = inline_colorization::color_reset;
            let v51: std::string::String = format!("{}{}{}", v14, v21, v49);
            fable_library_rust::String_::fromString(v51)
        }
        pub fn method68(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v13: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Documents::closure8(v5.clone(), string("source_dir"), ());
                ()
            };
            let v33: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v42: () = {
                Documents::closure8(v5.clone(), v0_1, ());
                ()
            };
            let v52: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v5.clone(), string("dist_dir"), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v5.clone(), v1_1, ());
                ()
            };
            let v89: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v99: () = {
                Documents::closure8(v5.clone(), string("cache_dir"), ());
                ()
            };
            let v108: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v117: () = {
                Documents::closure8(v5.clone(), v2, ());
                ()
            };
            let v126: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v5.clone(), string("hangul_spec"), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v154: () = {
                Documents::closure8(v5.clone(), v3, ());
                ()
            };
            let v164: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method67(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Documents::method68(v8, v9, v10, v11);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v12
            ))
        }
        pub fn closure24(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v8: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method67(
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    v34.clone(),
                    Documents::method8(v29, v30, v31, v32, v33, v34),
                    Documents::method66(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                ))
            };
        }
        pub fn closure26(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method69() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: std::fs::FileType) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn method70() -> Func1<std::fs::FileType, Documents::US11> {
            Func1::new(move |v: std::fs::FileType| Documents::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Documents::US11 {
            Documents::US11::US11_1(v0_1)
        }
        pub fn method71() -> Func1<std::string::String, Documents::US11> {
            Func1::new(move |v: std::string::String| Documents::closure28((), v))
        }
        pub fn closure25(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(
                /*;
                let v4: bool = */
                async {
                    /*;
                    let v6: bool = */
                    ();
                    let v8: bool = true;
                    let __future_init = Box::pin(
                        /*;
                        let v10: bool = */
                        async move {
                            /*;
                            let v12: bool = */
                            ();
                            let v14: async_walkdir::DirEntry = v0_1.clone();
                            let v16: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                            Output = Result<std::fs::FileType, std::io::Error>,
                                        > + Send,
                                >,
                            > = Box::pin(async_walkdir::DirEntry::file_type(&v14));
                            let v18: Result<std::fs::FileType, std::io::Error> = v16.await;
                            let v19 = Documents::method69();
                            let v32: Result<std::fs::FileType, std::string::String> =
                                v18.map_err(|x| v19(x));
                            let v35 = Documents::method70();
                            let v36 = Documents::method71();
                            let v37: Documents::US11 = match &v32 {
                                Err(v32_1_0) => v36(v32_1_0.clone()),
                                Ok(v32_0_0) => v35(v32_0_0.clone()),
                            };
                            let v213: Documents::US12 = if let Documents::US11::US11_0(v37_0_0) =
                                &v37
                            {
                                if std::fs::FileType::is_dir(&v37_0_0.clone()) {
                                    Documents::US12::US12_0
                                } else {
                                    let v43: std::path::PathBuf =
                                        async_walkdir::DirEntry::path(&v0_1.clone());
                                    let v50: std::path::Display = v43.display();
                                    let v83: std::string::String = format!("{}", v50);
                                    let v111: string = fable_library_rust::String_::fromString(v83);
                                    if if (endsWith3(v111.clone(), string(".md"), false)) == false {
                                        true
                                    } else {
                                        endsWith3(v111, string(".hangul.md"), false)
                                    } {
                                        Documents::US12::US12_0
                                    } else {
                                        Documents::US12::US12_2
                                    }
                                }
                            } else {
                                let v129: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                                let v136: std::path::Display = v129.display();
                                let v169: std::string::String = format!("{}", v136);
                                let v197: string = fable_library_rust::String_::fromString(v169);
                                if if (endsWith3(v197.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    endsWith3(v197, string(".hangul.md"), false)
                                } {
                                    Documents::US12::US12_0
                                } else {
                                    Documents::US12::US12_2
                                }
                            };
                            let v216: string = string("}");
                            let v221: bool = true;
                            let _fix_closure_v218 = v213;
                            let v228: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v218 "), (v216))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v229: bool = true;
                            _fix_closure_v218
                        },
                    ); // rust.fix_closure';
                    let v231 = __future_init;
                    let v233: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US12> + Send>,
                    > = v231;
                    let v235: Documents::US12 = v233.await;
                    let v244: async_walkdir::Filtering = match &v235 {
                        Documents::US12::US12_0 => async_walkdir::Filtering::Ignore,
                        Documents::US12::US12_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v245: string = string("}");
                    let v250: bool = true;
                    let _fix_closure_v247 = v244;
                    let v257: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v247 "), (v245))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v258: bool = true;
                    _fix_closure_v247
                },
            ); // rust.fix_closure';
            let v260 = __future_init;
            v260
        }
        pub fn closure30(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method73() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn method74() -> Func1<async_walkdir::DirEntry, Documents::US13> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
        }
        pub fn method75() -> Func1<std::string::String, Documents::US13> {
            Func1::new(move |v: std::string::String| Documents::closure32((), v))
        }
        pub fn method76() -> string {
            let v7: string = Documents::method13(getCharAt(toLower(string("Critical")), 0_i32));
            let v14: &str = inline_colorization::color_bright_red;
            let v21: &str = &*v7;
            let v49: &str = inline_colorization::color_reset;
            let v51: std::string::String = format!("{}{}{}", v14, v21, v49);
            fable_library_rust::String_::fromString(v51)
        }
        pub fn method78(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v2.clone(), string("error"), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v39: std::string::String = format!("{:#?}", v0_1);
            let v78: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v39), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method77(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method78(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / stream_filter_map"),
                v9
            ))
        }
        pub fn closure33(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method77(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method76(),
                    v0_1,
                ))
            };
        }
        pub fn closure29(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method73();
            let v14: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17 = Documents::method74();
            let v18 = Documents::method75();
            let v19: Documents::US13 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v144: Documents::US5 = match &v19 {
                Documents::US13::US13_0(v19_0_0) => {
                    let v22: std::path::PathBuf = async_walkdir::DirEntry::path(&v19_0_0.clone());
                    let v29: std::path::Display = v22.display();
                    let v62: std::string::String = format!("{}", v29);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v62))
                }
                Documents::US13::US13_1(v19_1_0) => {
                    let v95: () = {
                        Documents::closure33(v19_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v144 {
                Documents::US5::US5_0(v144_0_0) => Some(
                    match &v144 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method72(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure29((), v)
                },
            )
        }
        pub fn method80(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v2.clone(), string("files_len"), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v39: std::string::String = format!("{:#?}", v0_1);
            let v78: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v39), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method79(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v9: string = Documents::method80(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v9
            ))
        }
        pub fn closure34(v0_1: Vec<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method79(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method66(),
                    v0_1.len(),
                ))
            };
        }
        pub fn method81() -> string {
            string("")
        }
        pub fn method82(v0_1: string) -> string {
            Documents::method38(Documents::method61(v0_1))
        }
        pub fn method84(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v0_1
        }
        pub fn method86() -> string {
            string("")
        }
        pub fn closure38(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure37(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure38(v0_1, v)
            })
        }
        pub fn method87() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure37((), v))
        }
        pub fn method88(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method88: loop {
                break '_method88 (match v0_1.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Documents::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == (v4);
                        let patternInput: (i32, i32) = if v6 {
                            ((v2.get().clone()) + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), (v3.get().clone()) + 1_i32)
                        };
                        {
                            let v0_1_temp: LrcPtr<Documents::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = if v6 {
                                let v13: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v24: LrcPtr<StringBuilder> = {
                                    let value: string = ofChar(v4);
                                    v1_1.get().clone().Append_Z721C83C5(value)
                                };
                                v1_1.get().clone()
                            };
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method88;
                        }
                    }
                });
            }
        }
        pub fn closure39(v0_1: i32, v1_1: i32, v2: string) -> string {
            if (v1_1) >= (v0_1) {
                v2.clone()
            } else {
                (Documents::method89(v0_1, (v1_1) + 1_i32))(append((v2), string(" ")))
            }
        }
        pub fn method89(v0_1: i32, v1_1: i32) -> Func1<string, string> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure39(v0_1, v1_1, v)
            })
        }
        pub fn closure36(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\"' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let v54: i32 = length(v51.clone());
                    let v55: Array<char> = new_init(&'\u{0000}', v54);
                    let v56: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method63(v54, v56.clone()) {
                        let v58: i32 = v56.l0.get().clone();
                        let v59: char = getCharAt(v51.clone(), v58);
                        v55.get_mut()[v58 as usize] = v59;
                        {
                            let v60: i32 = (v58) + 1_i32;
                            v56.l0.set(v60);
                            ()
                        }
                    }
                    {
                        let v62: List<char> = ofArray(v55.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method87())(b0)(b1)
                                }),
                                v62,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US15::US15_0(
                            v10,
                            v45,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v105: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v105) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v105) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn closure40(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\'' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let v54: i32 = length(v51.clone());
                    let v55: Array<char> = new_init(&'\u{0000}', v54);
                    let v56: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method63(v54, v56.clone()) {
                        let v58: i32 = v56.l0.get().clone();
                        let v59: char = getCharAt(v51.clone(), v58);
                        v55.get_mut()[v58 as usize] = v59;
                        {
                            let v60: i32 = (v58) + 1_i32;
                            v56.l0.set(v60);
                            ()
                        }
                    }
                    {
                        let v62: List<char> = ofArray(v55.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method87())(b0)(b1)
                                }),
                                v62,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US15::US15_0(
                            v10,
                            v45,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v105: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v105) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v105) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn method90(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method90: loop {
                break '_method90 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US15::US15_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US15 = (match v2.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Documents::US15::US15_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => {
                                v7.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method90;
                            }
                        }
                    }
                });
            }
        }
        pub fn method91(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method91: loop {
                break '_method91 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US17::US17_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US17::US17_0(v11_0_0) => match &v11 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method91;
                    }
                });
            }
        }
        pub fn method92(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method92: loop {
                break '_method92 ({
                    let v137: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method91(v25, 0_i64)) == false {
                            let v62: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v68: string = ofChar(v25);
                            let v71: i32 = length(v68.clone());
                            let v72: Array<char> = new_init(&'\u{0000}', v71);
                            let v73: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method63(v71, v73.clone()) {
                                let v75: i32 = v73.l0.get().clone();
                                let v76: char = getCharAt(v68.clone(), v75);
                                v72.get_mut()[v75 as usize] = v76;
                                {
                                    let v77: i32 = (v75) + 1_i32;
                                    v73.l0.set(v77);
                                    ()
                                }
                            }
                            {
                                let v79: List<char> = ofArray(v72.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method87())(b0)(b1)
                                                },
                                            ),
                                            v79,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US15::US15_0(
                                    v25,
                                    v62,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v149: Documents::US15 = match &v137 {
                        Documents::US15::US15_0(
                            v137_0_0,
                            v137_0_1,
                            v137_0_2,
                            v137_0_3,
                            v137_0_4,
                        ) => {
                            let v138: char = v137_0_0.clone();
                            Documents::US15::US15_0(
                                if '\\' == (v138) { '/' } else { v138 },
                                v137_0_1.clone(),
                                v137_0_2.clone(),
                                v137_0_3.clone(),
                                v137_0_4.clone(),
                            )
                        }
                        Documents::US15::US15_1(v137_1_0) => {
                            Documents::US15::US15_1(v137_1_0.clone())
                        }
                    };
                    match &v149 {
                        Documents::US15::US15_0(
                            v149_0_0,
                            v149_0_1,
                            v149_0_2,
                            v149_0_3,
                            v149_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v149_0_0.clone())));
                            let v1_1_temp: string = v149_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v149_0_2.clone();
                            let v3_temp: i32 = v149_0_3.clone();
                            let v4_temp: i32 = v149_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method92;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method93(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH1>,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v4.clone());
            '_method93: loop {
                break '_method93 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US15::US15_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US15 = (match v4.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US15::US15_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH1> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method93;
                            }
                        }
                    }
                });
            }
        }
        pub fn method94(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method94: loop {
                break '_method94 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US17::US17_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US17::US17_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US17::US17_0(v15_0_0) => match &v15 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method94;
                    }
                });
            }
        }
        pub fn method95(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method95: loop {
                break '_method95 ({
                    let v145: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method94(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let v75: i32 = length(v72.clone());
                            let v76: Array<char> = new_init(&'\u{0000}', v75);
                            let v77: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method63(v75, v77.clone()) {
                                let v79: i32 = v77.l0.get().clone();
                                let v80: char = getCharAt(v72.clone(), v79);
                                v76.get_mut()[v79 as usize] = v80;
                                {
                                    let v81: i32 = (v79) + 1_i32;
                                    v77.l0.set(v81);
                                    ()
                                }
                            }
                            {
                                let v83: List<char> = ofArray(v76.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method87())(b0)(b1)
                                                },
                                            ),
                                            v83,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US15::US15_0(
                                    v29,
                                    v66,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v157: Documents::US15 = match &v145 {
                        Documents::US15::US15_0(
                            v145_0_0,
                            v145_0_1,
                            v145_0_2,
                            v145_0_3,
                            v145_0_4,
                        ) => {
                            let v146: char = v145_0_0.clone();
                            Documents::US15::US15_0(
                                if '\\' == (v146) { '/' } else { v146 },
                                v145_0_1.clone(),
                                v145_0_2.clone(),
                                v145_0_3.clone(),
                                v145_0_4.clone(),
                            )
                        }
                        Documents::US15::US15_1(v145_1_0) => {
                            Documents::US15::US15_1(v145_1_0.clone())
                        }
                    };
                    match &v157 {
                        Documents::US15::US15_0(
                            v157_0_0,
                            v157_0_1,
                            v157_0_2,
                            v157_0_3,
                            v157_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v157_0_0.clone())));
                            let v1_1_temp: string = v157_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v157_0_2.clone();
                            let v3_temp: i32 = v157_0_3.clone();
                            let v4_temp: i32 = v157_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method95;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method96(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method96: loop {
                break '_method96 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method96;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method97(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method97: loop {
                break '_method97 ({
                    let v100: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v11: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v45: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v51: string = ofChar(v11);
                        let v54: i32 = length(v51.clone());
                        let v55: Array<char> = new_init(&'\u{0000}', v54);
                        let v56: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method63(v54, v56.clone()) {
                            let v58: i32 = v56.l0.get().clone();
                            let v59: char = getCharAt(v51.clone(), v58);
                            v55.get_mut()[v58 as usize] = v59;
                            {
                                let v60: i32 = (v58) + 1_i32;
                                v56.l0.set(v60);
                                ()
                            }
                        }
                        {
                            let v62: List<char> = ofArray(v55.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method87())(b0)(b1)
                                        }),
                                        v62,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v11,
                                v45,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    };
                    match &v100 {
                        Documents::US15::US15_0(
                            v100_0_0,
                            v100_0_1,
                            v100_0_2,
                            v100_0_3,
                            v100_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v100_0_0.clone())));
                            let v1_1_temp: string = v100_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v100_0_2.clone();
                            let v3_temp: i32 = v100_0_3.clone();
                            let v4_temp: i32 = v100_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method97;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method85(v0_1: string) -> Documents::US14 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v9: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v15: LrcPtr<StringBuilder> =
                    StringBuilder::_ctor__Z721C83C5(Documents::method86());
                fn v18(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US15 {
                    Documents::closure36((), arg10_0040)
                }
                fn v19(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US15 {
                    Documents::closure40((), arg10_0040_1)
                }
                let v23: Documents::US15 = Documents::method90(
                    v9.clone(),
                    v15.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v18),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v19),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v235: Documents::US16 = match &v23 {
                    Documents::US15::US15_0(v23_0_0, v23_0_1, v23_0_2, v23_0_3, v23_0_4) => {
                        let v28: i32 = v23_0_4.clone();
                        let v27: i32 = v23_0_3.clone();
                        let v26: LrcPtr<StringBuilder> = v23_0_2.clone();
                        let v25: string = v23_0_1.clone();
                        let v161: Documents::US15 = if string("") == (v25.clone()) {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v26.clone(), v27, v28)
                            ))
                        } else {
                            let v49: char = getCharAt(v25.clone(), 0_i32);
                            if (Documents::method91(v49, 0_i64)) == false {
                                let v86: string = getSlice(
                                    v25.clone(),
                                    Some(1_i32),
                                    Some((length(v25.clone())) - 1_i32),
                                );
                                let v92: string = ofChar(v49);
                                let v95: i32 = length(v92.clone());
                                let v96: Array<char> = new_init(&'\u{0000}', v95);
                                let v97: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method63(v95, v97.clone()) {
                                    let v99: i32 = v97.l0.get().clone();
                                    let v100: char = getCharAt(v92.clone(), v99);
                                    v96.get_mut()[v99 as usize] = v100;
                                    {
                                        let v101: i32 = (v99) + 1_i32;
                                        v97.l0.set(v101);
                                        ()
                                    }
                                }
                                {
                                    let v103: List<char> = ofArray(v96.clone());
                                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method88(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method87())(b0)(b1)
                                                    },
                                                ),
                                                v103,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v26.clone(),
                                            v27,
                                            v28,
                                        );
                                    Documents::US15::US15_0(
                                        v49,
                                        v86,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v49,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v26.clone(),
                                                                          v27,
                                                                          v28)))
                            }
                        };
                        let v173: Documents::US15 = match &v161 {
                            Documents::US15::US15_0(
                                v161_0_0,
                                v161_0_1,
                                v161_0_2,
                                v161_0_3,
                                v161_0_4,
                            ) => {
                                let v162: char = v161_0_0.clone();
                                Documents::US15::US15_0(
                                    if '\\' == (v162) { '/' } else { v162 },
                                    v161_0_1.clone(),
                                    v161_0_2.clone(),
                                    v161_0_3.clone(),
                                    v161_0_4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v161_1_0) => {
                                Documents::US15::US15_1(v161_1_0.clone())
                            }
                        };
                        let v193: Documents::US16 = match &v173 {
                            Documents::US15::US15_0(
                                v173_0_0,
                                v173_0_1,
                                v173_0_2,
                                v173_0_3,
                                v173_0_4,
                            ) => {
                                let patternInput_1: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method92(
                                    ofChar(v173_0_0.clone()),
                                    v173_0_1.clone(),
                                    v173_0_2.clone(),
                                    v173_0_3.clone(),
                                    v173_0_4.clone(),
                                );
                                Documents::US16::US16_0(
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                    patternInput_1.4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v173_1_0) => {
                                Documents::US16::US16_1(v173_1_0.clone())
                            }
                        };
                        let v203: Documents::US16 = match &v193 {
                            Documents::US16::US16_0(
                                v193_0_0,
                                v193_0_1,
                                v193_0_2,
                                v193_0_3,
                                v193_0_4,
                            ) => Documents::US16::US16_0(
                                v193_0_0.clone(),
                                v193_0_1.clone(),
                                v193_0_2.clone(),
                                v193_0_3.clone(),
                                v193_0_4.clone(),
                            ),
                            _ => Documents::US16::US16_0(
                                string(""),
                                v25.clone(),
                                v26.clone(),
                                v27,
                                v28,
                            ),
                        };
                        match &v203 {
                            Documents::US16::US16_0(
                                v203_0_0,
                                v203_0_1,
                                v203_0_2,
                                v203_0_3,
                                v203_0_4,
                            ) => {
                                let v208: i32 = v203_0_4.clone();
                                let v207: i32 = v203_0_3.clone();
                                let v206: LrcPtr<StringBuilder> = v203_0_2.clone();
                                let v205: string = v203_0_1.clone();
                                let v212: Documents::US15 = Documents::method93(
                                    v205.clone(),
                                    v206.clone(),
                                    v207,
                                    v208,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v18),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v19),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v212 {
                                        Documents::US15::US15_0(v212_0_0,
                                                                v212_0_1,
                                                                v212_0_2,
                                                                v212_0_3,
                                                                v212_0_4) =>
                                        Documents::US16::US16_0(v203_0_0.clone(),
                                                                v212_0_1.clone(),
                                                                v212_0_2.clone(),
                                                                v212_0_3.clone(),
                                                                v212_0_4.clone()),
                                        Documents::US15::US15_1(v212_1_0) =>
                                        Documents::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                         v212_1_0.clone(),
                                                                         (v9.clone(),
                                                                          v15.clone(),
                                                                          1_i32,
                                                                          1_i32),
                                                                         (v25.clone(),
                                                                          v26.clone(),
                                                                          v27,
                                                                          v28),
                                                                         (v205.clone(),
                                                                          v206.clone(),
                                                                          v207,
                                                                          v208))),
                                    }
                            }
                            _ => Documents::US16::US16_1(string(
                                "parsing.between / expected content",
                            )),
                        }
                    }
                    Documents::US15::US15_1(v23_1_0) => Documents::US16::US16_1(v23_1_0.clone()),
                };
                let v493: Documents::US16 = match &v235 {
                    Documents::US16::US16_0(v235_0_0, v235_0_1, v235_0_2, v235_0_3, v235_0_4) => {
                        v235.clone()
                    }
                    _ => {
                        let v384: Documents::US15 = if string("") == (v9.clone()) {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v15.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v266: char = getCharAt(v9.clone(), 0_i32);
                            if (Documents::method94(v266, 0_i64)) == false {
                                let v303: string = getSlice(
                                    v9.clone(),
                                    Some(1_i32),
                                    Some((length(v9.clone())) - 1_i32),
                                );
                                let v309: string = ofChar(v266);
                                let v312: i32 = length(v309.clone());
                                let v313: Array<char> = new_init(&'\u{0000}', v312);
                                let v314: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method63(v312, v314.clone()) {
                                    let v316: i32 = v314.l0.get().clone();
                                    let v317: char = getCharAt(v309.clone(), v316);
                                    v313.get_mut()[v316 as usize] = v317;
                                    {
                                        let v318: i32 = (v316) + 1_i32;
                                        v314.l0.set(v318);
                                        ()
                                    }
                                }
                                {
                                    let v320: List<char> = ofArray(v313.clone());
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method88(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method87())(b0)(b1)
                                                    },
                                                ),
                                                v320,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v15.clone(),
                                            1_i32,
                                            1_i32,
                                        );
                                    Documents::US15::US15_0(
                                        v266,
                                        v303,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v266,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v15.clone(),
                                                                          1_i32,
                                                                          1_i32)))
                            }
                        };
                        let v396: Documents::US15 = match &v384 {
                            Documents::US15::US15_0(
                                v384_0_0,
                                v384_0_1,
                                v384_0_2,
                                v384_0_3,
                                v384_0_4,
                            ) => {
                                let v385: char = v384_0_0.clone();
                                Documents::US15::US15_0(
                                    if '\\' == (v385) { '/' } else { v385 },
                                    v384_0_1.clone(),
                                    v384_0_2.clone(),
                                    v384_0_3.clone(),
                                    v384_0_4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v384_1_0) => {
                                Documents::US15::US15_1(v384_1_0.clone())
                            }
                        };
                        let v416: Documents::US16 = match &v396 {
                            Documents::US15::US15_0(
                                v396_0_0,
                                v396_0_1,
                                v396_0_2,
                                v396_0_3,
                                v396_0_4,
                            ) => {
                                let patternInput_3: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method95(
                                    ofChar(v396_0_0.clone()),
                                    v396_0_1.clone(),
                                    v396_0_2.clone(),
                                    v396_0_3.clone(),
                                    v396_0_4.clone(),
                                );
                                Documents::US16::US16_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                    patternInput_3.4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v396_1_0) => {
                                Documents::US16::US16_1(v396_1_0.clone())
                            }
                        };
                        match &v416 {
                            Documents::US16::US16_0(
                                v416_0_0,
                                v416_0_1,
                                v416_0_2,
                                v416_0_3,
                                v416_0_4,
                            ) => v416.clone(),
                            _ => {
                                let v431: Documents::US18 = if (length(v9.clone())) == 0_i32 {
                                    Documents::US18::US18_0(v9.clone(), v15.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US18::US18_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v9.clone()
                                    ))
                                };
                                let v440: Documents::US16 = match &v431 {
                                    Documents::US18::US18_0(
                                        v431_0_0,
                                        v431_0_1,
                                        v431_0_2,
                                        v431_0_3,
                                    ) => Documents::US16::US16_0(
                                        string(""),
                                        v431_0_0.clone(),
                                        v431_0_1.clone(),
                                        v431_0_2.clone(),
                                        v431_0_3.clone(),
                                    ),
                                    Documents::US18::US18_1(v431_1_0) => {
                                        Documents::US16::US16_1(v431_1_0.clone())
                                    }
                                };
                                match &v440 {
                                    Documents::US16::US16_0(
                                        v440_0_0,
                                        v440_0_1,
                                        v440_0_2,
                                        v440_0_3,
                                        v440_0_4,
                                    ) => {
                                        let v442: string = v440_0_1.clone();
                                        Documents::US16::US16_0(
                                            v440_0_0.clone(),
                                            getSlice(
                                                v442.clone(),
                                                Some(Documents::method96(v442.clone(), 0_i32)),
                                                Some((length(v442)) - 1_i32),
                                            ),
                                            v440_0_2.clone(),
                                            v440_0_3.clone(),
                                            v440_0_4.clone(),
                                        )
                                    }
                                    Documents::US16::US16_1(v440_1_0) => {
                                        Documents::US16::US16_1(v440_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v821: Documents::US19 = match &v493 {
                    Documents::US16::US16_0(v493_0_0, v493_0_1, v493_0_2, v493_0_3, v493_0_4) => {
                        let v498: i32 = v493_0_4.clone();
                        let v497: i32 = v493_0_3.clone();
                        let v496: LrcPtr<StringBuilder> = v493_0_2.clone();
                        let v495: string = v493_0_1.clone();
                        let v658: Documents::US15 = if string("") == (v495.clone()) {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v496.clone(), v497, v498)
                            ))
                        } else {
                            let v505: char = getCharAt(v495.clone(), 0_i32);
                            if (v505) == ' ' {
                                let v540: string = getSlice(
                                    v495.clone(),
                                    Some(1_i32),
                                    Some((length(v495.clone())) - 1_i32),
                                );
                                let v546: string = ofChar(v505);
                                let v549: i32 = length(v546.clone());
                                let v550: Array<char> = new_init(&'\u{0000}', v549);
                                let v551: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method63(v549, v551.clone()) {
                                    let v553: i32 = v551.l0.get().clone();
                                    let v554: char = getCharAt(v546.clone(), v553);
                                    v550.get_mut()[v553 as usize] = v554;
                                    {
                                        let v555: i32 = (v553) + 1_i32;
                                        v551.l0.set(v555);
                                        ()
                                    }
                                }
                                {
                                    let v557: List<char> = ofArray(v550.clone());
                                    let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method88(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method87())(b0)(b1)
                                                    },
                                                ),
                                                v557,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v496.clone(),
                                            v497,
                                            v498,
                                        );
                                    Documents::US15::US15_0(
                                        v505,
                                        v540,
                                        patternInput_4.0.clone(),
                                        patternInput_4.1.clone(),
                                        patternInput_4.2.clone(),
                                    )
                                }
                            } else {
                                let v600: i32 = (indexOf(v495.clone(), string("\n"))) - 1_i32;
                                Documents::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                            ' ',
                                                                                            v497,
                                                                                            v498,
                                                                                            v496.clone(),
                                                                                            getSlice(v495.clone(),
                                                                                                     Some(0_i32),
                                                                                                     Some((if -2_i32
                                                                                                                  ==
                                                                                                                  (v600)
                                                                                                              {
                                                                                                               (length(v495.clone()))
                                                                                                                   +
                                                                                                                   1_i32
                                                                                                           } else {
                                                                                                               (v600)
                                                                                                                   +
                                                                                                                   1_i32
                                                                                                           })
                                                                                                              -
                                                                                                              1_i32))),
                                                                                   string("\n"),
                                                                                   append(((Documents::method89((v498)
                                                                                                                    -
                                                                                                                    1_i32,
                                                                                                                0_i32))(string(""))),
                                                                                          string("^")),
                                                                                   string("\n")])))
                            }
                        };
                        let v670: Documents::US20 = match &v658 {
                            Documents::US15::US15_0(
                                v658_0_0,
                                v658_0_1,
                                v658_0_2,
                                v658_0_3,
                                v658_0_4,
                            ) => Documents::US20::US20_0(
                                Documents::US17::US17_0(v658_0_0.clone()),
                                v658_0_1.clone(),
                                v658_0_2.clone(),
                                v658_0_3.clone(),
                                v658_0_4.clone(),
                            ),
                            _ => Documents::US20::US20_0(
                                Documents::US17::US17_1,
                                v495.clone(),
                                v496.clone(),
                                v497,
                                v498,
                            ),
                        };
                        let v795: Documents::US16 = match &v670 {
                            Documents::US20::US20_0(
                                v670_0_0,
                                v670_0_1,
                                v670_0_2,
                                v670_0_3,
                                v670_0_4,
                            ) => {
                                let v675: i32 = v670_0_4.clone();
                                let v674: i32 = v670_0_3.clone();
                                let v673: LrcPtr<StringBuilder> = v670_0_2.clone();
                                let v672: string = v670_0_1.clone();
                                let v771: Documents::US15 = if string("") == (v672.clone()) {
                                    Documents::US15::US15_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v673.clone(), v674, v675)
                                    ))
                                } else {
                                    let v682: char = getCharAt(v672.clone(), 0_i32);
                                    let v716: string = getSlice(
                                        v672.clone(),
                                        Some(1_i32),
                                        Some((length(v672)) - 1_i32),
                                    );
                                    let v722: string = ofChar(v682);
                                    let v725: i32 = length(v722.clone());
                                    let v726: Array<char> = new_init(&'\u{0000}', v725);
                                    let v727: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method63(v725, v727.clone()) {
                                        let v729: i32 = v727.l0.get().clone();
                                        let v730: char = getCharAt(v722.clone(), v729);
                                        v726.get_mut()[v729 as usize] = v730;
                                        {
                                            let v731: i32 = (v729) + 1_i32;
                                            v727.l0.set(v731);
                                            ()
                                        }
                                    }
                                    {
                                        let v733: List<char> = ofArray(v726.clone());
                                        let patternInput_5:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Documents::method88(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method87())(b0)(b1)),
                                                                                     v733,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v673,
                                                                            v674,
                                                                            v675);
                                        Documents::US15::US15_0(
                                            v682,
                                            v716,
                                            patternInput_5.0.clone(),
                                            patternInput_5.1.clone(),
                                            patternInput_5.2.clone(),
                                        )
                                    }
                                };
                                match &v771 {
                                    Documents::US15::US15_0(
                                        v771_0_0,
                                        v771_0_1,
                                        v771_0_2,
                                        v771_0_3,
                                        v771_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Documents::method97(
                                            ofChar(v771_0_0.clone()),
                                            v771_0_1.clone(),
                                            v771_0_2.clone(),
                                            v771_0_3.clone(),
                                            v771_0_4.clone(),
                                        );
                                        Documents::US16::US16_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Documents::US15::US15_1(v771_1_0) => {
                                        Documents::US16::US16_1(v771_1_0.clone())
                                    }
                                }
                            }
                            Documents::US20::US20_1(v670_1_0) => {
                                Documents::US16::US16_1(v670_1_0.clone())
                            }
                        };
                        let v807: Documents::US21 = match &v795 {
                            Documents::US16::US16_0(
                                v795_0_0,
                                v795_0_1,
                                v795_0_2,
                                v795_0_3,
                                v795_0_4,
                            ) => Documents::US21::US21_0(
                                Documents::US5::US5_0(v795_0_0.clone()),
                                v795_0_1.clone(),
                                v795_0_2.clone(),
                                v795_0_3.clone(),
                                v795_0_4.clone(),
                            ),
                            _ => Documents::US21::US21_0(
                                Documents::US5::US5_1,
                                v495.clone(),
                                v496.clone(),
                                v497,
                                v498,
                            ),
                        };
                        match &v807 {
                            Documents::US21::US21_0(
                                v807_0_0,
                                v807_0_1,
                                v807_0_2,
                                v807_0_3,
                                v807_0_4,
                            ) => Documents::US19::US19_0(
                                v493_0_0.clone(),
                                v807_0_0.clone(),
                                v807_0_1.clone(),
                                v807_0_2.clone(),
                                v807_0_3.clone(),
                                v807_0_4.clone(),
                            ),
                            Documents::US21::US21_1(v807_1_0) => {
                                Documents::US19::US19_1(v807_1_0.clone())
                            }
                        }
                    }
                    Documents::US16::US16_1(v493_1_0) => Documents::US19::US19_1(v493_1_0.clone()),
                };
                match &v821 {
                    Documents::US19::US19_0(
                        v821_0_0,
                        v821_0_1,
                        v821_0_2,
                        v821_0_3,
                        v821_0_4,
                        v821_0_5,
                    ) => Documents::US14::US14_0(v821_0_0.clone(), v821_0_1.clone()),
                    Documents::US19::US19_1(v821_1_0) => Documents::US14::US14_1(v821_1_0.clone()),
                }
            }
        }
        pub fn method100(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method100: loop {
                break '_method100 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US17::US17_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US17::US17_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US17::US17_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US17::US17_0(v19_0_0) => match &v19 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method100;
                    }
                });
            }
        }
        pub fn method101(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method101: loop {
                break '_method101 ({
                    let v153: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method100(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let v79: i32 = length(v76.clone());
                            let v80: Array<char> = new_init(&'\u{0000}', v79);
                            let v81: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method63(v79, v81.clone()) {
                                let v83: i32 = v81.l0.get().clone();
                                let v84: char = getCharAt(v76.clone(), v83);
                                v80.get_mut()[v83 as usize] = v84;
                                {
                                    let v85: i32 = (v83) + 1_i32;
                                    v81.l0.set(v85);
                                    ()
                                }
                            }
                            {
                                let v87: List<char> = ofArray(v80.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method87())(b0)(b1)
                                                },
                                            ),
                                            v87,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US15::US15_0(
                                    v33,
                                    v70,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v33,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v153 {
                        Documents::US15::US15_0(
                            v153_0_0,
                            v153_0_1,
                            v153_0_2,
                            v153_0_3,
                            v153_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v153_0_0.clone())));
                            let v1_1_temp: string = v153_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v153_0_2.clone();
                            let v3_temp: i32 = v153_0_3.clone();
                            let v4_temp: i32 = v153_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method101;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method103(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method103: loop {
                break '_method103 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US17::US17_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US17::US17_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US17::US17_0(v15_0_0) => match &v15 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method103;
                    }
                });
            }
        }
        pub fn closure41(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v164: Documents::US15 = if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\\' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let v54: i32 = length(v51.clone());
                    let v55: Array<char> = new_init(&'\u{0000}', v54);
                    let v56: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method63(v54, v56.clone()) {
                        let v58: i32 = v56.l0.get().clone();
                        let v59: char = getCharAt(v51.clone(), v58);
                        v55.get_mut()[v58 as usize] = v59;
                        {
                            let v60: i32 = (v58) + 1_i32;
                            v56.l0.set(v60);
                            ()
                        }
                    }
                    {
                        let v62: List<char> = ofArray(v55.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method87())(b0)(b1)
                                }),
                                v62,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US15::US15_0(
                            v10,
                            v45,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v105: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v105) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v105) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v269: Documents::US15 = match &v164 {
                Documents::US15::US15_0(v164_0_0, v164_0_1, v164_0_2, v164_0_3, v164_0_4) => {
                    let v169: i32 = v164_0_4.clone();
                    let v168: i32 = v164_0_3.clone();
                    let v167: LrcPtr<StringBuilder> = v164_0_2.clone();
                    let v166: string = v164_0_1.clone();
                    if string("") == (v166.clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v167.clone(), v168, v169)
                        ))
                    } else {
                        let v176: char = getCharAt(v166.clone(), 0_i32);
                        let v210: string =
                            getSlice(v166.clone(), Some(1_i32), Some((length(v166)) - 1_i32));
                        let v216: string = ofChar(v176);
                        let v219: i32 = length(v216.clone());
                        let v220: Array<char> = new_init(&'\u{0000}', v219);
                        let v221: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method63(v219, v221.clone()) {
                            let v223: i32 = v221.l0.get().clone();
                            let v224: char = getCharAt(v216.clone(), v223);
                            v220.get_mut()[v223 as usize] = v224;
                            {
                                let v225: i32 = (v223) + 1_i32;
                                v221.l0.set(v225);
                                ()
                            }
                        }
                        {
                            let v227: List<char> = ofArray(v220.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method87())(b0)(b1)
                                        }),
                                        v227,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v167,
                                    v168,
                                    v169,
                                );
                            Documents::US15::US15_0(
                                v176,
                                v210,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US15::US15_1(v164_1_0) => Documents::US15::US15_1(v164_1_0.clone()),
            };
            match &v269 {
                Documents::US15::US15_0(v269_0_0, v269_0_1, v269_0_2, v269_0_3, v269_0_4) => {
                    Documents::US16::US16_0(
                        append((ofChar('\\')), (ofChar(v269_0_0.clone()))),
                        v269_0_1.clone(),
                        v269_0_2.clone(),
                        v269_0_3.clone(),
                        v269_0_4.clone(),
                    )
                }
                Documents::US15::US15_1(v269_1_0) => Documents::US16::US16_1(v269_1_0.clone()),
            }
        }
        pub fn closure42(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v164: Documents::US15 = if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '`' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let v54: i32 = length(v51.clone());
                    let v55: Array<char> = new_init(&'\u{0000}', v54);
                    let v56: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method63(v54, v56.clone()) {
                        let v58: i32 = v56.l0.get().clone();
                        let v59: char = getCharAt(v51.clone(), v58);
                        v55.get_mut()[v58 as usize] = v59;
                        {
                            let v60: i32 = (v58) + 1_i32;
                            v56.l0.set(v60);
                            ()
                        }
                    }
                    {
                        let v62: List<char> = ofArray(v55.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method87())(b0)(b1)
                                }),
                                v62,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US15::US15_0(
                            v10,
                            v45,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v105: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v105) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v105) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v269: Documents::US15 = match &v164 {
                Documents::US15::US15_0(v164_0_0, v164_0_1, v164_0_2, v164_0_3, v164_0_4) => {
                    let v169: i32 = v164_0_4.clone();
                    let v168: i32 = v164_0_3.clone();
                    let v167: LrcPtr<StringBuilder> = v164_0_2.clone();
                    let v166: string = v164_0_1.clone();
                    if string("") == (v166.clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v167.clone(), v168, v169)
                        ))
                    } else {
                        let v176: char = getCharAt(v166.clone(), 0_i32);
                        let v210: string =
                            getSlice(v166.clone(), Some(1_i32), Some((length(v166)) - 1_i32));
                        let v216: string = ofChar(v176);
                        let v219: i32 = length(v216.clone());
                        let v220: Array<char> = new_init(&'\u{0000}', v219);
                        let v221: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method63(v219, v221.clone()) {
                            let v223: i32 = v221.l0.get().clone();
                            let v224: char = getCharAt(v216.clone(), v223);
                            v220.get_mut()[v223 as usize] = v224;
                            {
                                let v225: i32 = (v223) + 1_i32;
                                v221.l0.set(v225);
                                ()
                            }
                        }
                        {
                            let v227: List<char> = ofArray(v220.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method87())(b0)(b1)
                                        }),
                                        v227,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v167,
                                    v168,
                                    v169,
                                );
                            Documents::US15::US15_0(
                                v176,
                                v210,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US15::US15_1(v164_1_0) => Documents::US15::US15_1(v164_1_0.clone()),
            };
            match &v269 {
                Documents::US15::US15_0(v269_0_0, v269_0_1, v269_0_2, v269_0_3, v269_0_4) => {
                    Documents::US16::US16_0(
                        append((ofChar('`')), (ofChar(v269_0_0.clone()))),
                        v269_0_1.clone(),
                        v269_0_2.clone(),
                        v269_0_3.clone(),
                        v269_0_4.clone(),
                    )
                }
                Documents::US15::US15_1(v269_1_0) => Documents::US16::US16_1(v269_1_0.clone()),
            }
        }
        pub fn method104(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH3>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v4.clone());
            '_method104: loop {
                break '_method104 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US16::US16_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US16 = (match v4.get().clone().as_ref() {
                            Documents::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US16::US16_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH3> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH3::UH3_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method104;
                            }
                        }
                    }
                });
            }
        }
        pub fn method105(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method105: loop {
                break '_method105 (match v0_1.get().clone().as_ref() {
                    Documents::UH2::UH2_0 => v1_1.get().clone(),
                    Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Documents::UH2> = match v0_1.get().clone().as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(Documents::UH2::UH2_1(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method105;
                    }
                });
            }
        }
        pub fn method102(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US23 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method102: loop {
                break '_method102 ({
                    let v145: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method103(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let v75: i32 = length(v72.clone());
                            let v76: Array<char> = new_init(&'\u{0000}', v75);
                            let v77: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method63(v75, v77.clone()) {
                                let v79: i32 = v77.l0.get().clone();
                                let v80: char = getCharAt(v72.clone(), v79);
                                v76.get_mut()[v79 as usize] = v80;
                                {
                                    let v81: i32 = (v79) + 1_i32;
                                    v77.l0.set(v81);
                                    ()
                                }
                            }
                            {
                                let v83: List<char> = ofArray(v76.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method87())(b0)(b1)
                                                },
                                            ),
                                            v83,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US15::US15_0(
                                    v29,
                                    v66,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v160: Documents::US16 = match &v145 {
                        Documents::US15::US15_0(
                            v145_0_0,
                            v145_0_1,
                            v145_0_2,
                            v145_0_3,
                            v145_0_4,
                        ) => Documents::US16::US16_0(
                            ofChar(v145_0_0.clone()),
                            v145_0_1.clone(),
                            v145_0_2.clone(),
                            v145_0_3.clone(),
                            v145_0_4.clone(),
                        ),
                        Documents::US15::US15_1(v145_1_0) => {
                            Documents::US16::US16_1(v145_1_0.clone())
                        }
                    };
                    let v174: Documents::US16 = match &v160 {
                        Documents::US16::US16_0(
                            v160_0_0,
                            v160_0_1,
                            v160_0_2,
                            v160_0_3,
                            v160_0_4,
                        ) => v160.clone(),
                        _ => Documents::method104(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure41((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Documents::UH3::UH3_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Documents::closure42((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v174 {
                        Documents::US16::US16_0(
                            v174_0_0,
                            v174_0_1,
                            v174_0_2,
                            v174_0_3,
                            v174_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v174_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v174_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v174_0_2.clone();
                            let v3_temp: i32 = v174_0_3.clone();
                            let v4_temp: i32 = v174_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method102;
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method105(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method106(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method106(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method107(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US23 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method107: loop {
                break '_method107 ({
                    let v145: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method103(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let v75: i32 = length(v72.clone());
                            let v76: Array<char> = new_init(&'\u{0000}', v75);
                            let v77: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method63(v75, v77.clone()) {
                                let v79: i32 = v77.l0.get().clone();
                                let v80: char = getCharAt(v72.clone(), v79);
                                v76.get_mut()[v79 as usize] = v80;
                                {
                                    let v81: i32 = (v79) + 1_i32;
                                    v77.l0.set(v81);
                                    ()
                                }
                            }
                            {
                                let v83: List<char> = ofArray(v76.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method87())(b0)(b1)
                                                },
                                            ),
                                            v83,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US15::US15_0(
                                    v29,
                                    v66,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v160: Documents::US16 = match &v145 {
                        Documents::US15::US15_0(
                            v145_0_0,
                            v145_0_1,
                            v145_0_2,
                            v145_0_3,
                            v145_0_4,
                        ) => Documents::US16::US16_0(
                            ofChar(v145_0_0.clone()),
                            v145_0_1.clone(),
                            v145_0_2.clone(),
                            v145_0_3.clone(),
                            v145_0_4.clone(),
                        ),
                        Documents::US15::US15_1(v145_1_0) => {
                            Documents::US16::US16_1(v145_1_0.clone())
                        }
                    };
                    match &v160 {
                        Documents::US16::US16_0(
                            v160_0_0,
                            v160_0_1,
                            v160_0_2,
                            v160_0_3,
                            v160_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v160_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v160_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v160_0_2.clone();
                            let v3_temp: i32 = v160_0_3.clone();
                            let v4_temp: i32 = v160_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method107;
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method105(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method99(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US23 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method99: loop {
                break '_method99 ({
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v153: Documents::US15 = if v5 {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method100(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let v79: i32 = length(v76.clone());
                            let v80: Array<char> = new_init(&'\u{0000}', v79);
                            let v81: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method63(v79, v81.clone()) {
                                let v83: i32 = v81.l0.get().clone();
                                let v84: char = getCharAt(v76.clone(), v83);
                                v80.get_mut()[v83 as usize] = v84;
                                {
                                    let v85: i32 = (v83) + 1_i32;
                                    v81.l0.set(v85);
                                    ()
                                }
                            }
                            {
                                let v87: List<char> = ofArray(v80.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method87())(b0)(b1)
                                                },
                                            ),
                                            v87,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US15::US15_0(
                                    v33,
                                    v70,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v33,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v173: Documents::US16 = match &v153 {
                        Documents::US15::US15_0(
                            v153_0_0,
                            v153_0_1,
                            v153_0_2,
                            v153_0_3,
                            v153_0_4,
                        ) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method101(
                                    ofChar(v153_0_0.clone()),
                                    v153_0_1.clone(),
                                    v153_0_2.clone(),
                                    v153_0_3.clone(),
                                    v153_0_4.clone(),
                                );
                            Documents::US16::US16_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Documents::US15::US15_1(v153_1_0) => {
                            Documents::US16::US16_1(v153_1_0.clone())
                        }
                    };
                    let v635: Documents::US16 = match &v173 {
                        Documents::US16::US16_0(
                            v173_0_0,
                            v173_0_1,
                            v173_0_2,
                            v173_0_3,
                            v173_0_4,
                        ) => v173.clone(),
                        _ => {
                            let v339: Documents::US15 = if v5 {
                                Documents::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                  '\"',
                                                                                  (v2.get().clone(),
                                                                                   v3.get().clone(),
                                                                                   v4.get().clone())))
                            } else {
                                let v185: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if (v185) == '\"' {
                                    let v220: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some((length(v1_1.get().clone())) - 1_i32),
                                    );
                                    let v226: string = ofChar(v185);
                                    let v229: i32 = length(v226.clone());
                                    let v230: Array<char> = new_init(&'\u{0000}', v229);
                                    let v231: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method63(v229, v231.clone()) {
                                        let v233: i32 = v231.l0.get().clone();
                                        let v234: char = getCharAt(v226.clone(), v233);
                                        v230.get_mut()[v233 as usize] = v234;
                                        {
                                            let v235: i32 = (v233) + 1_i32;
                                            v231.l0.set(v235);
                                            ()
                                        }
                                    }
                                    {
                                        let v237: List<char> = ofArray(v230.clone());
                                        let patternInput_2:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method88(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method87())(b0)(b1)),
                                                                                          v237,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US15::US15_0(
                                            v185,
                                            v220,
                                            patternInput_2.0.clone(),
                                            patternInput_2.1.clone(),
                                            patternInput_2.2.clone(),
                                        )
                                    }
                                } else {
                                    let v280: i32 =
                                        (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                    Documents::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                         '\"',
                                                                                                         v3.get().clone(),
                                                                                                         v4.get().clone(),
                                                                                                         v2.get().clone(),
                                                                                                         getSlice(v1_1.get().clone(),
                                                                                                                  Some(0_i32),
                                                                                                                  Some((if -2_i32
                                                                                                                               ==
                                                                                                                               (v280)
                                                                                                                           {
                                                                                                                            (length(v1_1.get().clone()))
                                                                                                                                +
                                                                                                                                1_i32
                                                                                                                        } else {
                                                                                                                            (v280)
                                                                                                                                +
                                                                                                                                1_i32
                                                                                                                        })
                                                                                                                           -
                                                                                                                           1_i32))),
                                                                                                string("\n"),
                                                                                                append(((Documents::method89((v4.get().clone())
                                                                                                                                 -
                                                                                                                                 1_i32,
                                                                                                                             0_i32))(string(""))),
                                                                                                       string("^")),
                                                                                                string("\n")])))
                                }
                            };
                            let v566: Documents::US16 = match &v339 {
                                Documents::US15::US15_0(
                                    v339_0_0,
                                    v339_0_1,
                                    v339_0_2,
                                    v339_0_3,
                                    v339_0_4,
                                ) => {
                                    let v344: i32 = v339_0_4.clone();
                                    let v343: i32 = v339_0_3.clone();
                                    let v342: LrcPtr<StringBuilder> = v339_0_2.clone();
                                    let v341: string = v339_0_1.clone();
                                    let v346: Documents::US23 = Documents::method102(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v341.clone(),
                                        v342.clone(),
                                        v343,
                                        v344,
                                    );
                                    let v377: Documents::US16 = match &v346 {
                                        Documents::US23::US23_0(
                                            v346_0_0,
                                            v346_0_1,
                                            v346_0_2,
                                            v346_0_3,
                                            v346_0_4,
                                        ) => {
                                            let v353: List<string> = Documents::method106(
                                                v346_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v353 = v353.clone();
                                                        move || ofList(v353.clone()).clone()
                                                    }))),
                                                ),
                                                v346_0_1.clone(),
                                                v346_0_2.clone(),
                                                v346_0_3.clone(),
                                                v346_0_4.clone(),
                                            )
                                        }
                                        Documents::US23::US23_1(v346_1_0) => {
                                            Documents::US16::US16_1(v346_1_0.clone())
                                        }
                                    };
                                    match &v377 {
                                        Documents::US16::US16_0(
                                            v377_0_0,
                                            v377_0_1,
                                            v377_0_2,
                                            v377_0_3,
                                            v377_0_4,
                                        ) => {
                                            let v382: i32 = v377_0_4.clone();
                                            let v381: i32 = v377_0_3.clone();
                                            let v380: LrcPtr<StringBuilder> = v377_0_2.clone();
                                            let v379: string = v377_0_1.clone();
                                            let v543: Documents::US15 = if string("")
                                                == (v379.clone())
                                            {
                                                Documents::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                                      '\"',
                                                                                                      (v380.clone(),
                                                                                                       v381,
                                                                                                       v382)))
                                            } else {
                                                let v389: char = getCharAt(v379.clone(), 0_i32);
                                                if (v389) == '\"' {
                                                    let v424: string = getSlice(
                                                        v379.clone(),
                                                        Some(1_i32),
                                                        Some((length(v379.clone())) - 1_i32),
                                                    );
                                                    let v430: string = ofChar(v389);
                                                    let v433: i32 = length(v430.clone());
                                                    let v434: Array<char> =
                                                        new_init(&'\u{0000}', v433);
                                                    let v435: LrcPtr<Documents::Mut6> =
                                                        LrcPtr::new(Documents::Mut6 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method63(v433, v435.clone()) {
                                                        let v437: i32 = v435.l0.get().clone();
                                                        let v438: char =
                                                            getCharAt(v430.clone(), v437);
                                                        v434.get_mut()[v437 as usize] = v438;
                                                        {
                                                            let v439: i32 = (v437) + 1_i32;
                                                            v435.l0.set(v439);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v441: List<char> =
                                                            ofArray(v434.clone());
                                                        let patternInput_3:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Documents::method88(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method87())(b0)(b1)),
                                                                                                              v441,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v380.clone(),
                                                                                                     v381,
                                                                                                     v382);
                                                        Documents::US15::US15_0(
                                                            v389,
                                                            v424,
                                                            patternInput_3.0.clone(),
                                                            patternInput_3.1.clone(),
                                                            patternInput_3.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v484: i32 =
                                                        (indexOf(v379.clone(), string("\n")))
                                                            - 1_i32;
                                                    Documents::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                             '\"',
                                                                                                                             v381,
                                                                                                                             v382,
                                                                                                                             v380.clone(),
                                                                                                                             getSlice(v379.clone(),
                                                                                                                                      Some(0_i32),
                                                                                                                                      Some((if -2_i32
                                                                                                                                                   ==
                                                                                                                                                   (v484)
                                                                                                                                               {
                                                                                                                                                (length(v379.clone()))
                                                                                                                                                    +
                                                                                                                                                    1_i32
                                                                                                                                            } else {
                                                                                                                                                (v484)
                                                                                                                                                    +
                                                                                                                                                    1_i32
                                                                                                                                            })
                                                                                                                                               -
                                                                                                                                               1_i32))),
                                                                                                                    string("\n"),
                                                                                                                    append(((Documents::method89((v382)
                                                                                                                                                     -
                                                                                                                                                     1_i32,
                                                                                                                                                 0_i32))(string(""))),
                                                                                                                           string("^")),
                                                                                                                    string("\n")])))
                                                }
                                            };
                                            match &v543 {
                                                                 Documents::US15::US15_0(v543_0_0,
                                                                                         v543_0_1,
                                                                                         v543_0_2,
                                                                                         v543_0_3,
                                                                                         v543_0_4)
                                                                 =>
                                                                 Documents::US16::US16_0(v377_0_0.clone(),
                                                                                         v543_0_1.clone(),
                                                                                         v543_0_2.clone(),
                                                                                         v543_0_3.clone(),
                                                                                         v543_0_4.clone()),
                                                                 Documents::US15::US15_1(v543_1_0)
                                                                 =>
                                                                 Documents::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v543_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v341.clone(),
                                                                                                   v342.clone(),
                                                                                                   v343,
                                                                                                   v344),
                                                                                                  (v379.clone(),
                                                                                                   v380.clone(),
                                                                                                   v381,
                                                                                                   v382))),
                                                             }
                                        }
                                        _ => Documents::US16::US16_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Documents::US15::US15_1(v339_1_0) => {
                                    Documents::US16::US16_1(v339_1_0.clone())
                                }
                            };
                            match &v566 {
                                Documents::US16::US16_0(
                                    v566_0_0,
                                    v566_0_1,
                                    v566_0_2,
                                    v566_0_3,
                                    v566_0_4,
                                ) => v566.clone(),
                                _ => {
                                    let v578: Documents::US16 =
                                                     Documents::method104(v1_1.get().clone(),
                                                                          v2.get().clone(),
                                                                          v3.get().clone(),
                                                                          v4.get().clone(),
                                                                          LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                           |arg10_0040:
                                                                                                                                (string,
                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                 i32,
                                                                                                                                 i32)|
                                                                                                                           Documents::closure41((),
                                                                                                                                                arg10_0040)),
                                                                                                            LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                             |arg10_0040_1:
                                                                                                                                                                  (string,
                                                                                                                                                                   LrcPtr<StringBuilder>,
                                                                                                                                                                   i32,
                                                                                                                                                                   i32)|
                                                                                                                                                             Documents::closure42((),
                                                                                                                                                                                  arg10_0040_1)),
                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v589: Documents::US16 = match &v578 {
                                        Documents::US16::US16_0(
                                            v578_0_0,
                                            v578_0_1,
                                            v578_0_2,
                                            v578_0_3,
                                            v578_0_4,
                                        ) => Documents::US16::US16_0(
                                            string(""),
                                            v578_0_1.clone(),
                                            v578_0_2.clone(),
                                            v578_0_3.clone(),
                                            v578_0_4.clone(),
                                        ),
                                        Documents::US16::US16_1(v578_1_0) => {
                                            Documents::US16::US16_1(v578_1_0.clone())
                                        }
                                    };
                                    let v600: Documents::US23 = match &v589 {
                                        Documents::US16::US16_0(
                                            v589_0_0,
                                            v589_0_1,
                                            v589_0_2,
                                            v589_0_3,
                                            v589_0_4,
                                        ) => Documents::method107(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v589_0_1.clone(),
                                            v589_0_2.clone(),
                                            v589_0_3.clone(),
                                            v589_0_4.clone(),
                                        ),
                                        Documents::US16::US16_1(v589_1_0) => {
                                            Documents::US23::US23_1(v589_1_0.clone())
                                        }
                                    };
                                    match &v600 {
                                        Documents::US23::US23_0(
                                            v600_0_0,
                                            v600_0_1,
                                            v600_0_2,
                                            v600_0_3,
                                            v600_0_4,
                                        ) => {
                                            let v607: List<string> = Documents::method106(
                                                v600_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v607 = v607.clone();
                                                        move || ofList(v607.clone()).clone()
                                                    }))),
                                                ),
                                                v600_0_1.clone(),
                                                v600_0_2.clone(),
                                                v600_0_3.clone(),
                                                v600_0_4.clone(),
                                            )
                                        }
                                        Documents::US23::US23_1(v600_1_0) => {
                                            Documents::US16::US16_1(v600_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v635 {
                        Documents::US16::US16_0(
                            v635_0_0,
                            v635_0_1,
                            v635_0_2,
                            v635_0_3,
                            v635_0_4,
                        ) => {
                            let v640: i32 = v635_0_4.clone();
                            let v639: i32 = v635_0_3.clone();
                            let v638: LrcPtr<StringBuilder> = v635_0_2.clone();
                            let v637: string = v635_0_1.clone();
                            let v636: string = v635_0_0.clone();
                            let v642: i32 = Documents::method96(v637.clone(), 0_i32);
                            let v684: Documents::US18 = if 0_i32 == (v642) {
                                Documents::US18::US18_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US18::US18_0(
                                    getSlice(
                                        v637.clone(),
                                        Some(v642),
                                        Some((length(v637.clone())) - 1_i32),
                                    ),
                                    v638.clone(),
                                    v639,
                                    v640,
                                )
                            };
                            match &v684 {
                                Documents::US18::US18_0(v684_0_0, v684_0_1, v684_0_2, v684_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v636.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v684_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v684_0_1.clone();
                                    let v3_temp: i32 = v684_0_2.clone();
                                    let v4_temp: i32 = v684_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method99;
                                }
                                _ => Documents::US23::US23_0(
                                    Documents::method105(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v636.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v637.clone(),
                                    v638.clone(),
                                    v639,
                                    v640,
                                ),
                            }
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method105(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method98(v0_1: string) -> Documents::US22 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v21: Documents::US23 = Documents::method99(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method86()),
                    1_i32,
                    1_i32,
                );
                match &v21 {
                    Documents::US23::US23_0(v21_0_0, v21_0_1, v21_0_2, v21_0_3, v21_0_4) => {
                        Documents::US22::US22_0(toArray(Documents::method106(
                            v21_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US23::US23_1(v21_1_0) => Documents::US22::US22_1(v21_1_0.clone()),
                }
            }
        }
        pub fn method109(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v18: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v57: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v67: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v85: () = {
                Documents::closure8(v10.clone(), v1_1, ());
                ()
            };
            let v94: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v141: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v159: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v169: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v178: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v187: std::string::String = format!("{:#?}", v3);
            let v226: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v187),
                    (),
                );
                ()
            };
            let v235: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v245: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v267: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v276: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v286: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v295: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v304: std::string::String = format!("{:#?}", v5);
            let v343: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v304),
                    (),
                );
                ()
            };
            let v352: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v362: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v380: std::string::String = format!("{:#?}", v6);
            let v419: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v380),
                    (),
                );
                ()
            };
            let v428: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v438: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v447: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v459: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v468: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v478: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v487: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v496: std::string::String = format!("{:#?}", v8);
            let v535: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v496),
                    (),
                );
                ()
            };
            let v545: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v554: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method108(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method109(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options"),
                v17
            ))
        }
        pub fn closure43(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
                let v13: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v39: Option<i64> = patternInput.5.clone();
                let v38: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v37: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v36: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v35: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v34: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method108(
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    Documents::method8(v34, v35, v36, v37, v38, v39),
                    Documents::method66(),
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn closure44(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method110() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure44((), v))
        }
        pub fn closure45(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US24 {
            Documents::US24::US24_0(v0_1)
        }
        pub fn method111(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US24>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure45((), v)
                },
            )
        }
        pub fn closure46(unitVar: (), v0_1: std::string::String) -> Documents::US24 {
            Documents::US24::US24_1(v0_1)
        }
        pub fn method112() -> Func1<std::string::String, Documents::US24> {
            Func1::new(move |v: std::string::String| Documents::closure46((), v))
        }
        pub fn method113(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method78(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v9
            ))
        }
        pub fn closure47(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method113(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method76(),
                    v0_1,
                ))
            };
        }
        pub fn method114(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure48(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method115(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure48((), v))
        }
        pub fn closure49(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method116() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure49((), v)
            })
        }
        pub fn method117() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure49((), v)
            })
        }
        pub fn closure50(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method118() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure50((), v)
                },
            )
        }
        pub fn closure51(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn method119() -> Func1<std::string::String, Documents::US26> {
            Func1::new(move |v: std::string::String| Documents::closure51((), v))
        }
        pub fn closure52(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn method120() -> Func1<std::string::String, Documents::US26> {
            Func1::new(move |v: std::string::String| Documents::closure52((), v))
        }
        pub fn method122(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v3.clone(), string("trace\'"), ());
                ()
            };
            let v31: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(
                    v3.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v53: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v3.clone(), string("e"), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v81: std::string::String = format!("{:#?}", v1_1);
            let v120: () = {
                Documents::closure8(v3.clone(), fable_library_rust::String_::fromString(v81), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method121(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: std::string::String,
        ) -> string {
            let v10: string = Documents::method122(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.stdio_line"),
                v10
            ))
        }
        pub fn closure53(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v6: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method121(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method76(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method123() -> string {
            let v7: string = Documents::method13(getCharAt(toLower(string("Verbose")), 0_i32));
            let v14: &str = inline_colorization::color_bright_black;
            let v21: &str = &*v7;
            let v49: &str = inline_colorization::color_reset;
            let v51: std::string::String = format!("{}{}{}", v14, v21, v49);
            fable_library_rust::String_::fromString(v51)
        }
        pub fn method125() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method124(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Documents::method125();
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure54(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method124(
                        v26.clone(),
                        v27.clone(),
                        v28.clone(),
                        v29.clone(),
                        v30.clone(),
                        v31.clone(),
                        Documents::method8(v26, v27, v28, v29, v30, v31),
                        Documents::method123(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure55(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method126(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure55((), v)
            })
        }
        pub fn method127(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure56(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method128() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US27,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure56((), v)
                },
            )
        }
        pub fn method129(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure57(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method130(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US28>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure57((), v)
                },
            )
        }
        pub fn method131(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure58(unitVar: (), v0_1: std::process::Output) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method132() -> Func1<std::process::Output, Documents::US29> {
            Func1::new(move |v: std::process::Output| Documents::closure58((), v))
        }
        pub fn closure59(unitVar: (), v0_1: std::string::String) -> Documents::US29 {
            Documents::US29::US29_1(v0_1)
        }
        pub fn method133() -> Func1<std::string::String, Documents::US29> {
            Func1::new(move |v: std::string::String| Documents::closure59((), v))
        }
        pub fn method134(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method78(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v9
            ))
        }
        pub fn closure60(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method134(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method76(),
                    v0_1,
                ))
            };
        }
        pub fn closure61(unitVar: (), v0_1: i32) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method135() -> Func1<i32, Documents::US30> {
            Func1::new(move |v: i32| Documents::closure61((), v))
        }
        pub fn method136() -> string {
            string("\n")
        }
        pub fn method138(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v31: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v40: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v50: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v60: () = {
                Documents::closure8(v3.clone(), string("std_trace_length"), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v78: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method137(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Documents::method138(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure62(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v6: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method137(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method123(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method142(
            v0_1: string,
            v1_1: Documents::US5,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v18: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v57: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v67: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v89: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v98: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v108: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v117: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v126: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v154: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v173: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v182: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v191: std::string::String = format!("{:#?}", v3);
            let v230: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v191),
                    (),
                );
                ()
            };
            let v239: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v249: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v258: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v271: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v280: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v290: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v299: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v308: std::string::String = format!("{:#?}", v5);
            let v347: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v308),
                    (),
                );
                ()
            };
            let v356: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v366: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v375: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v384: std::string::String = format!("{:#?}", v6);
            let v423: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v384),
                    (),
                );
                ()
            };
            let v432: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v442: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v451: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v463: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v472: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v482: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v491: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v500: std::string::String = format!("{:#?}", v8);
            let v539: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v500),
                    (),
                );
                ()
            };
            let v549: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v558: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method141(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: Documents::US5,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method142(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
            ))
        }
        pub fn closure63(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: Documents::US5,
            v8: string,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
                let v13: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v39: Option<i64> = patternInput.5.clone();
                let v38: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v37: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v36: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v35: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v34: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method141(
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    Documents::method8(v34, v35, v36, v37, v38, v39),
                    Documents::method66(),
                    v8,
                    v7,
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method143(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Array<(string, string)> {
            v2
        }
        pub fn method146(v0_1: bool) -> string {
            unbox::<string>(fable_library_rust::Native_::getZero())
        }
        pub fn closure65(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method147() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US31> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure65((), v)
            })
        }
        pub fn method148(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn closure66(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method124(
                        v26.clone(),
                        v27.clone(),
                        v28.clone(),
                        v29.clone(),
                        v30.clone(),
                        v31.clone(),
                        Documents::method8(v26, v27, v28, v29, v30, v31),
                        Documents::method123(),
                        v0_1,
                    )
                })
            };
        }
        pub fn method145(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method144(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            Documents::method145(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
        }
        pub fn closure64(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) {
            let v11: Arc<Async<()>> =
                Documents::method144(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
            fable_library_rust::Native_::getZero::<()>();
            ()
        }
        pub fn closure67(unitVar: (), v0_1: CancellationToken) -> Documents::US32 {
            Documents::US32::US32_0(v0_1)
        }
        pub fn method149() -> Func1<CancellationToken, Documents::US32> {
            Func1::new(move |v: CancellationToken| Documents::closure67((), v))
        }
        pub fn method150(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method151(v0_1: bool) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method152(v0_1: bool) {
            ();
        }
        pub fn closure68(v0_1: bool, unitVar: ()) {
            if (Documents::method151(v0_1)) == false {
                Documents::method152(v0_1);
            };
        }
        pub fn method155(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v2.clone(), string("ex"), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v39: std::string::String = format!("{:#?}", v0_1);
            let v78: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v39), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method154(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<TaskCanceledException>,
        ) -> string {
            let v9: string = Documents::method155(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure69(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method154(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method35(),
                    v0_1,
                ))
            };
        }
        pub fn method153(
            v0_1: bool,
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method157(
            v0_1: i32,
            v1_1: i32,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v18: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v10.clone(), string("exit_code"), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v67: () = {
                Documents::closure8(v10.clone(), string("output_length"), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v85: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v141: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v159: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v169: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v178: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v187: std::string::String = format!("{:#?}", v3);
            let v226: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v187),
                    (),
                );
                ()
            };
            let v235: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v245: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v267: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v276: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v286: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v295: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v304: std::string::String = format!("{:#?}", v5);
            let v343: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v304),
                    (),
                );
                ()
            };
            let v352: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v362: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v380: std::string::String = format!("{:#?}", v6);
            let v419: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v380),
                    (),
                );
                ()
            };
            let v428: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v438: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v447: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v459: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v468: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v478: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v487: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v496: std::string::String = format!("{:#?}", v8);
            let v535: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v496),
                    (),
                );
                ()
            };
            let v545: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v554: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method156(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method157(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
            ))
        }
        pub fn closure70(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: i32,
            v8: string,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
                let v13: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v39: Option<i64> = patternInput.5.clone();
                let v38: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v37: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v36: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v35: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v34: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method156(
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    Documents::method8(v34, v35, v36, v37, v38, v39),
                    Documents::method66(),
                    v7,
                    length(v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method140(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method139(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            Documents::method140(v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method83(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v17: Documents::US14 = Documents::method85(Documents::method84(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US5) = match &v17 {
                Documents::US14::US14_0(v17_0_0, v17_0_1) => (v17_0_0.clone(), v17_0_1.clone()),
                Documents::US14::US14_1(v17_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v17_1_0.clone()
                    ])),
                ),
            };
            let v30: Documents::US5 = patternInput.1.clone();
            let v29: string = patternInput.0.clone();
            let v35: Documents::US22 = Documents::method98(match &v30 {
                Documents::US5::US5_0(v30_0_0) => match &v30 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v44: Array<string> = match &v35 {
                Documents::US22::US22_0(v35_0_0) => v35_0_0.clone(),
                Documents::US22::US22_1(v35_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v35_1_0.clone()
                    ])),
                ),
            };
            let v46: Vec<string> = v44.to_vec();
            let v48: bool = true;
            let _vec_map: Vec<_> = v46
                .into_iter()
                .map(|x| {
                    //;
                    let v50: string = x;
                    let v57: &str = &*v50;
                    let v90: std::string::String = String::from(v57);
                    let v118: bool = true;
                    v90
                })
                .collect::<Vec<_>>();
            let v120: Vec<std::string::String> = _vec_map;
            let v123: () = {
                Documents::closure43(
                    v0_1,
                    v1_1,
                    v2.clone(),
                    v3,
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v29.clone(),
                    v120.clone(),
                    (),
                );
                ()
            };
            let _capture_v175: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
                    let v120 = v120.clone();
                    let v2 = v2.clone();
                    let v29 = v29.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    move || {
                        let v177: std::process::Command = std::process::Command::new(&*v29.clone());
                        let v179: bool = true;
                        let mut v177 = v177;
                        let v181: bool = true;
                        std::process::Command::args(&mut v177, &*v120.clone());
                        let v183: std::process::Command = v177;
                        let v185: std::process::Stdio = std::process::Stdio::piped();
                        let v187: bool = true;
                        let mut v183 = v183;
                        let v189: bool = true;
                        std::process::Command::stdout(&mut v183, std::process::Stdio::piped());
                        let v191: std::process::Command = v183;
                        let v193: std::process::Stdio = std::process::Stdio::piped();
                        let v195: bool = true;
                        let mut v191 = v191;
                        let v197: bool = true;
                        std::process::Command::stderr(&mut v191, std::process::Stdio::piped());
                        let v199: std::process::Command = v191;
                        let v201: std::process::Stdio = std::process::Stdio::piped();
                        let v203: bool = true;
                        let mut v199 = v199;
                        let v205: bool = true;
                        std::process::Command::stdin(&mut v199, std::process::Stdio::piped());
                        let v207: std::process::Command = v199;
                        let v224: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v238: std::process::Command = match &v224 {
                            Documents::US5::US5_0(v224_0_0) => {
                                let v230: bool = true;
                                let mut v207 = v207;
                                let v232: bool = true;
                                std::process::Command::current_dir(
                                    &mut v207,
                                    &*match &v224 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v207
                            }
                            _ => v207,
                        };
                        let v260: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v238
                        } else {
                            let v242: Vec<(string, string)> = v2.clone().to_vec();
                            let v244: bool = true;
                            let _vec_fold_ = v242.into_iter().fold(v238, |acc, x| {
                                //;
                                let v246: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v251: bool = true;
                                let mut v246 = v246;
                                let v253: bool = true;
                                std::process::Command::env(
                                    &mut v246,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v255: std::process::Command = v246;
                                let v257: bool = true;
                                v255
                            });
                            _vec_fold_
                        };
                        let v262: bool = true;
                        let mut v260 = v260;
                        let v264: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v260);
                        let v265 = Documents::method69();
                        let v269: Result<std::process::Child, std::string::String> =
                            v264.map_err(|x| v265(x));
                        let v281 = Documents::method110();
                        let v283: bool = true;
                        let _result_map_ = v269.map(|x| {
                            //;
                            let v290: Option<std::process::Child> = v281(Some(x));
                            let v292: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v290);
                            let v294: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v292);
                            let v296: bool = true;
                            v294
                        });
                        let v298: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v299 = Documents::method111();
                        let v300 = Documents::method112();
                        let v302: Documents::US24 = match v298 {
                            Ok(x) => v299(x),
                            Err(e) => v300(e),
                        };
                        let patternInput_3: (i32, Documents::US6, Documents::US25) = match &v302 {
                            Documents::US24::US24_0(v302_0_0) => {
                                let v303: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v302_0_0.clone();
                                let v305: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v307: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v303.clone();
                                    let v309: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v307.lock();
                                    let v325: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method114(v309.unwrap());
                                    let v327: bool = true;
                                    let mut v325 = v325;
                                    let v329: &mut Option<std::process::Child> = &mut v325;
                                    let v331: Option<&mut std::process::Child> = v329.as_mut();
                                    let v333: &mut std::process::Child = v331.unwrap();
                                    let v335: &mut Option<std::process::ChildStdout> =
                                        &mut v333.stdout;
                                    let v337: Option<std::process::ChildStdout> =
                                        Option::take(v335);
                                    let v339: std::process::ChildStdout = v337.unwrap();
                                    let v341: bool = true;
                                    v339
                                })();
                                let v343: std::process::ChildStdout = _capture;
                                let v345: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v347: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v303.clone();
                                    let v349: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v347.lock();
                                    let v365: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method114(v349.unwrap());
                                    let v367: bool = true;
                                    let mut v365 = v365;
                                    let v369: &mut Option<std::process::Child> = &mut v365;
                                    let v371: Option<&mut std::process::Child> = v369.as_mut();
                                    let v373: &mut std::process::Child = v371.unwrap();
                                    let v375: &mut Option<std::process::ChildStderr> =
                                        &mut v373.stderr;
                                    let v377: Option<std::process::ChildStderr> =
                                        Option::take(v375);
                                    let v379: std::process::ChildStderr = v377.unwrap();
                                    let v381: bool = true;
                                    v379
                                })();
                                let v383: std::process::ChildStderr = _capture;
                                let v385: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v387: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v303.clone();
                                    let v389: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v387.lock();
                                    let v405: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method114(v389.unwrap());
                                    let v407: bool = true;
                                    let mut v405 = v405;
                                    let v409: &mut Option<std::process::Child> = &mut v405;
                                    let v411: Option<&mut std::process::Child> = v409.as_mut();
                                    let v413: &mut std::process::Child = v411.unwrap();
                                    let v415: &mut Option<std::process::ChildStdin> =
                                        &mut v413.stdin;
                                    let v417: Option<std::process::ChildStdin> = Option::take(v415);
                                    let v419: std::process::ChildStdin = v417.unwrap();
                                    let v425: Option<std::process::ChildStdin> =
                                        (Documents::method115())(Some(v419));
                                    let v427: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v425);
                                    let v429: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v427);
                                    let v431: bool = true;
                                    v429
                                })();
                                let v433: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v435: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v438: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method116())(v435.clone());
                                let v440: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v438);
                                let v442: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v440);
                                let v444: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method117())(v435);
                                let v446: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v444);
                                let v448: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v446);
                                let v450: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method118())(patternInput_2.1.clone());
                                let v452: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v450);
                                let v454: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v452);
                                let v456: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v458: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v343);
                                    let v460: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v458);
                                    let v462: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v460);
                                    let v464: bool = true;
                                    let mut v462 = v462;
                                    let _iter_try_for_each = v462.try_for_each(|x| {
                                        //;
                                        let v466: Result<std::string::String, std::io::Error> = x;
                                        let v468: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v442.clone();
                                        let v469 = Documents::method69();
                                        let v473: Result<std::string::String, std::string::String> =
                                            v466.map_err(|x| v469(x));
                                        let v485 = Documents::method119();
                                        let v486 = Documents::method120();
                                        let v488: Documents::US26 = match v473 {
                                            Ok(x) => v485(x),
                                            Err(e) => v486(e),
                                        };
                                        let v725: std::string::String = match &v488 {
                                            Documents::US26::US26_0(v488_0_0) => {
                                                let v491: string =
                                                    fable_library_rust::String_::fromString(
                                                        v488_0_0.clone(),
                                                    );
                                                let v493: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v495: std::borrow::Cow<[u8]> =
                                                    v493.encode(&*v491).0;
                                                let v497: &[u8] = v495.as_ref();
                                                let v499: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v497);
                                                let v503: &str = v499.unwrap();
                                                let v542: std::string::String = String::from(v503);
                                                let v550: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v542.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v553: () = {
                                                        Documents::closure54(v550.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v605: () = {
                                                        Documents::closure11(v550, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v542
                                            }
                                            Documents::US26::US26_1(v488_1_0) => {
                                                let v607: std::string::String = v488_1_0.clone();
                                                let v610: () = {
                                                    Documents::closure53(v5, v607.clone(), ());
                                                    ()
                                                };
                                                let v657: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v607);
                                                let v664: &str = &*v657;
                                                String::from(v664)
                                            }
                                        };
                                        let v727: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v468;
                                        let v729: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v727.lock();
                                        let v733: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v729.unwrap();
                                        let v746: &std::sync::mpsc::Sender<std::string::String> =
                                            &v733;
                                        let v748: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v746.send(v725);
                                        let v749 = Documents::method126();
                                        let v753: Result<(), std::string::String> =
                                            v748.map_err(|x| v749(x));
                                        let v766: _ = v753;
                                        let v768: bool = true;
                                        v766
                                    }); //;
                                    let v771: Result<(), string> = Documents::method127(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v774: string = string("}");
                                    let v779: bool = true;
                                    let _fix_closure_v776 = v771;
                                    let v786: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v776 "),
                                                    (v774),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v787: bool = true;
                                    _fix_closure_v776
                                }); // rust.fix_closure';
                                let v789: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v791: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v793: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v383);
                                    let v795: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v793);
                                    let v797: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v795);
                                    let v799: bool = true;
                                    let mut v797 = v797;
                                    let _iter_try_for_each = v797.try_for_each(|x| {
                                        //;
                                        let v801: Result<std::string::String, std::io::Error> = x;
                                        let v803: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v448.clone();
                                        let v804 = Documents::method69();
                                        let v808: Result<std::string::String, std::string::String> =
                                            v801.map_err(|x| v804(x));
                                        let v820 = Documents::method119();
                                        let v821 = Documents::method120();
                                        let v823: Documents::US26 = match v808 {
                                            Ok(x) => v820(x),
                                            Err(e) => v821(e),
                                        };
                                        let v1126: std::string::String = match &v823 {
                                            Documents::US26::US26_0(v823_0_0) => {
                                                let v826: string =
                                                    fable_library_rust::String_::fromString(
                                                        v823_0_0.clone(),
                                                    );
                                                let v828: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v830: std::borrow::Cow<[u8]> =
                                                    v828.encode(&*v826).0;
                                                let v832: &[u8] = v830.as_ref();
                                                let v834: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v832);
                                                let v838: &str = v834.unwrap();
                                                let v877: std::string::String = String::from(v838);
                                                let v885: string = concat(new_array(&[
                                                    string("! "),
                                                    fable_library_rust::String_::fromString(
                                                        v877.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v888: () = {
                                                        Documents::closure54(v885.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v939: () = {
                                                        Documents::closure11(v885, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v941: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v877
                                                    );
                                                    let v948: &str = &*v941;
                                                    String::from(v948)
                                                }
                                            }
                                            Documents::US26::US26_1(v823_1_0) => {
                                                let v1008: std::string::String = v823_1_0.clone();
                                                let v1011: () = {
                                                    Documents::closure53(v5, v1008.clone(), ());
                                                    ()
                                                };
                                                let v1058: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v1008);
                                                let v1065: &str = &*v1058;
                                                String::from(v1065)
                                            }
                                        };
                                        let v1128: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v803;
                                        let v1130: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v1128.lock();
                                        let v1134: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v1130.unwrap();
                                        let v1147: &std::sync::mpsc::Sender<std::string::String> =
                                            &v1134;
                                        let v1149: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v1147.send(v1126);
                                        let v1150 = Documents::method126();
                                        let v1154: Result<(), std::string::String> =
                                            v1149.map_err(|x| v1150(x));
                                        let v1167: _ = v1154;
                                        let v1169: bool = true;
                                        v1167
                                    }); //;
                                    let v1172: Result<(), string> = Documents::method127(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v1173: string = string("}");
                                    let v1178: bool = true;
                                    let _fix_closure_v1175 = v1172;
                                    let v1185: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v1175 "),
                                                    (v1173),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v1186: bool = true;
                                    _fix_closure_v1175
                                }); // rust.fix_closure';
                                let v1188: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v1205: Documents::US27 = defaultValue(
                                    Documents::US27::US27_1,
                                    map(Documents::method128(), v4.clone()),
                                );
                                match &v1205 {
                                    Documents::US27::US27_0(v1205_0_0) => {
                                        let v1211: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v433.clone();
                                        let v1213: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v1211.lock();
                                        let v1229: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method129(v1213.unwrap());
                                        let v1231: bool = true;
                                        let mut v1229 = v1229;
                                        let v1233: &mut Option<std::process::ChildStdin> =
                                            &mut v1229;
                                        let v1235: Option<std::process::ChildStdin> =
                                            Option::take(v1233);
                                        let v1237: bool = true;
                                        let _optionm_map_ = v1235.map(|x| {
                                            //;
                                            let v1239: std::process::ChildStdin = x;
                                            let v1241: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v1239);
                                            let v1243: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v1241);
                                            let v1245: bool = true;
                                            v1243
                                        });
                                        let v1247: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v1264: Documents::US28 = defaultValue(
                                            Documents::US28::US28_1,
                                            map(Documents::method130(), v1247),
                                        );
                                        match &v1264 {
                                            Documents::US28::US28_0(v1264_0_0) => {
                                                let v1268: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v1264 {
                                                    Documents::US28::US28_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v1205 {
                                                    Documents::US27::US27_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v1268.clone()
                                                );
                                                {
                                                    let v1270: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v1268;
                                                    let v1272: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v1270.lock();
                                                    let v1288: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method131(v1272.unwrap());
                                                    let v1290: bool = true;
                                                    let mut v1288 = v1288;
                                                    let v1292: bool = true;
                                                    std::io::Write::flush(&mut *v1288).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v1294: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v303;
                                    let v1296: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1294.lock();
                                    let v1312: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method114(v1296.unwrap());
                                    let v1314: bool = true;
                                    let mut v1312 = v1312;
                                    let v1316: &mut Option<std::process::Child> = &mut v1312;
                                    let v1318: Option<std::process::Child> = Option::take(v1316);
                                    let v1320: std::process::Child = v1318.unwrap();
                                    let v1322: Result<std::process::Output, std::io::Error> =
                                        v1320.wait_with_output();
                                    let v1323 = Documents::method69();
                                    let v1336: Result<std::process::Output, std::string::String> =
                                        v1322.map_err(|x| v1323(x));
                                    let v1346: string = string("vec![v789, v1188]");
                                    let v1347: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v789, v1188];
                                    let v1349: bool = true;
                                    v1347.into_iter().for_each(|x| {
                                        //;
                                        let v1351: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v1353: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v1351);
                                        let v1357: Result<(), string> = v1353.unwrap();
                                        v1357.unwrap();
                                        {
                                            let v1374: bool = true;
                                            let v1376: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v1377 = Documents::method132();
                                        let v1378 = Documents::method133();
                                        let v1379: Documents::US29 = match &v1336 {
                                            Err(v1336_1_0) => v1378(v1336_1_0.clone()),
                                            Ok(v1336_0_0) => v1377(v1336_0_0.clone()),
                                        };
                                        match &v1379 {
                                            Documents::US29::US29_0(v1379_0_0) => {
                                                let v1382: std::process::ExitStatus =
                                                    v1379_0_0.clone().status;
                                                let v1384: Option<i32> = v1382.code();
                                                let v1401: Documents::US30 = defaultValue(
                                                    Documents::US30::US30_1,
                                                    map(Documents::method135(), v1384),
                                                );
                                                match &v1401 {
                                                    Documents::US30::US30_0(v1401_0_0) => (
                                                        match &v1401 {
                                                            Documents::US30::US30_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US6::US6_1,
                                                        Documents::US25::US25_0(v454.clone()),
                                                    ),
                                                    _ => {
                                                        let v1415:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US6::US6_0(String::from(
                                                                v1415,
                                                            )),
                                                            Documents::US25::US25_0(v454.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US29::US29_1(v1379_1_0) => {
                                                let v1483: std::string::String = v1379_1_0.clone();
                                                let v1486: () = {
                                                    Documents::closure60(v1483.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US6::US6_0(v1483),
                                                    Documents::US25::US25_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US24::US24_1(v302_1_0) => {
                                let v1541: std::string::String = v302_1_0.clone();
                                let v1544: () = {
                                    Documents::closure47(v1541.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US6::US6_0(v1541),
                                    Documents::US25::US25_1,
                                )
                            }
                        };
                        let v1598: Documents::US25 = patternInput_3.2.clone();
                        let v1597: Documents::US6 = patternInput_3.1.clone();
                        let v1596: i32 = patternInput_3.0.clone();
                        let v1606: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1598 {
                            Documents::US25::US25_0(v1598_0_0) => Some(
                                match &v1598 {
                                    Documents::US25::US25_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                None::<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                >
                            }
                        };
                        let v1608: bool = true;
                        let _optionm_map_ = v1606.map(|x| {
                            //;
                            let v1610: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1612: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1610;
                            let v1614: Result<
                                std::sync::MutexGuard<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                                std::sync::PoisonError<
                                    std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                >,
                            > = v1612.lock();
                            let v1618: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1614.unwrap();
                            let v1631 = v1618.iter();
                            let v1633: Vec<std::string::String> = v1631.collect::<Vec<_>>();
                            let v1635: bool = true;
                            let _vec_map: Vec<_> = v1633
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1637: std::string::String = x;
                                    let v1639: string =
                                        fable_library_rust::String_::fromString(v1637);
                                    let v1641: bool = true;
                                    v1639
                                })
                                .collect::<Vec<_>>();
                            let v1643: Vec<string> = _vec_map;
                            let v1647: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v1643.clone()),
                            );
                            let v1654: string = join(Documents::method136(), toArray_1(v1647));
                            let v1659: bool = true;
                            v1654
                        });
                        let v1661: Option<string> = _optionm_map_;
                        let v1668: Documents::US5 = match &v1597 {
                            Documents::US6::US6_0(v1597_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v1597 {
                                        Documents::US6::US6_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v1674: string = defaultValue(
                            match &v1668 {
                                Documents::US5::US5_0(v1668_0_0) => match &v1668 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v1661,
                        );
                        let v1679: () = {
                            Documents::closure62(v1596, v1674.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1596, v1674))
                    }
                }))();
                _capture_v175.set(Some(x_5))
            }
            {
                let v1731: LrcPtr<(i32, string)> = match &_capture_v175.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v175=None"),),
                    Some(_capture_v175_0_0) => _capture_v175_0_0.clone(),
                };
                let _run_target_args__v15: (i32, string) = (v1731.0.clone(), v1731.1.clone());
                (
                    _run_target_args__v15.0.clone(),
                    _run_target_args__v15.1.clone(),
                )
            }
        }
        pub fn method158(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method28(v2, Documents::method47(v1_1.clone()));
            let v9: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some((lastIndexOf(v1_1.clone(), string("."))) - 1_i32),
            );
            let v16: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some((lastIndexOf(v4.clone(), string("."))) - 1_i32),
            );
            let v25: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v25 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v9, string("."), v0_1.clone()]))
                },
                if v25 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v16, string("."), v0_1]))
                },
            )
        }
        pub fn method159() -> string {
            string("")
        }
        pub fn closure71(unitVar: (), v0_1: string) -> Documents::US34 {
            Documents::US34::US34_0(v0_1)
        }
        pub fn method160() -> Func1<string, Documents::US34> {
            Func1::new(move |v: string| Documents::closure71((), v))
        }
        pub fn closure72(unitVar: (), v0_1: std::string::String) -> Documents::US34 {
            Documents::US34::US34_1(v0_1)
        }
        pub fn method161() -> Func1<std::string::String, Documents::US34> {
            Func1::new(move |v: std::string::String| Documents::closure72((), v))
        }
        pub fn method163(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: i32,
            v6: string,
            v7: string,
            v8: Documents::US5,
            v9: string,
            v10: string,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v20: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v12.clone(), string("file"), ());
                ()
            };
            let v40: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v49: () = {
                Documents::closure8(v12.clone(), v0_1, ());
                ()
            };
            let v59: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v12.clone(), string("real_path"), ());
                ()
            };
            let v78: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v87: () = {
                Documents::closure8(v12.clone(), v1_1, ());
                ()
            };
            let v96: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v106: () = {
                Documents::closure8(v12.clone(), string("relative_path"), ());
                ()
            };
            let v115: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v124: () = {
                Documents::closure8(v12.clone(), v2, ());
                ()
            };
            let v133: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v143: () = {
                Documents::closure8(v12.clone(), string("origin_hash_exit_code"), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v161: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v180: () = {
                Documents::closure8(v12.clone(), string("origin_hash"), ());
                ()
            };
            let v189: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v198: () = {
                Documents::closure8(v12.clone(), v4, ());
                ()
            };
            let v207: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v217: () = {
                Documents::closure8(v12.clone(), string("local_git_hash_exit_code"), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v235: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v244: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v12.clone(), string("local_git_hash"), ());
                ()
            };
            let v263: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v272: () = {
                Documents::closure8(v12.clone(), v6, ());
                ()
            };
            let v281: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v291: () = {
                Documents::closure8(v12.clone(), string("hash1"), ());
                ()
            };
            let v300: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v309: () = {
                Documents::closure8(v12.clone(), v7, ());
                ()
            };
            let v318: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v328: () = {
                Documents::closure8(v12.clone(), string("hash2"), ());
                ()
            };
            let v337: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v350: () = {
                Documents::closure8(v12.clone(), sprintf!("{:?}", v8), ());
                ()
            };
            let v359: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v369: () = {
                Documents::closure8(v12.clone(), string("dist_path"), ());
                ()
            };
            let v378: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v387: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v396: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v406: () = {
                Documents::closure8(v12.clone(), string("cache_path"), ());
                ()
            };
            let v415: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v424: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v434: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            v12.l0.get().clone()
        }
        pub fn method162(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
            v12: i32,
            v13: string,
            v14: i32,
            v15: string,
            v16: string,
            v17: Documents::US5,
            v18: string,
            v19: string,
        ) -> string {
            let v20: string =
                Documents::method163(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v20
            ))
        }
        pub fn closure73(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: string,
            v7: i32,
            v8: string,
            v9: string,
            v10: Documents::US5,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_2) {
                let v15: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v41: Option<i64> = patternInput.5.clone();
                let v40: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v39: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v38: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v37: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v36: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                let v60: string =
                    string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2");
                Documents::method19(if (v60.clone()) == string("") {
                    string("")
                } else {
                    Documents::method162(
                        v36.clone(),
                        v37.clone(),
                        v38.clone(),
                        v39.clone(),
                        v40.clone(),
                        v41.clone(),
                        Documents::method8(v36, v37, v38, v39, v40, v41),
                        Documents::method12(),
                        v60,
                        v1_1,
                        v2,
                        v0_1,
                        v4,
                        v3,
                        v7,
                        v6,
                        v9,
                        v10,
                        v5,
                        v8,
                    )
                })
            };
        }
        pub fn closure74(unitVar: (), v0_1: u64) -> Documents::US35 {
            Documents::US35::US35_0(v0_1)
        }
        pub fn method165() -> Func1<u64, Documents::US35> {
            Func1::new(move |v: u64| Documents::closure74((), v))
        }
        pub fn closure75(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method166() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure75((), v))
        }
        pub fn method168(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v32: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v51: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v98: () = {
                Documents::closure8(v4.clone(), string("error"), ());
                ()
            };
            let v107: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v116: std::string::String = format!("{:#?}", v2);
            let v155: () = {
                Documents::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v116),
                    (),
                );
                ()
            };
            let v165: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method167(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: std::string::String,
        ) -> string {
            let v11: string = Documents::method168(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure76(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v7: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method167(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method35(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method170(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v32: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v51: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v98: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v107: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v116: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v126: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method169(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: u64,
        ) -> string {
            let v11: string = Documents::method170(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure77(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v7: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method169(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method66(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method164(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method69();
            let v18: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v21 = Documents::method165();
            let v22 = Documents::method166();
            let v23: Documents::US35 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v23 {
                Documents::US35::US35_0(v23_0_0) => {
                    let v27: () = {
                        Documents::closure77(v0_1.clone(), v1_1.clone(), v23_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US35::US35_1(v23_1_0) => {
                    let v77: () = {
                        Documents::closure76(v0_1.clone(), v1_1.clone(), v23_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method172(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method173(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method174(v0_1: string) -> string {
            v0_1
        }
        pub fn method175(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure80(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v21: string = Documents::method174(v0_1);
            let v23: &[u8] = v21.as_bytes();
            let v24: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method175(v9);
            let v26: bool = true;
            let mut v24 = v24;
            let v28: bool = true;
            std::io::Write::write_all(&mut *v24, v23).unwrap();
            ()
        }
        pub fn method176(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method178(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v32: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v51: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v4.clone(), string("result_len"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v98: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v107: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v116: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v126: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method177(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
            v10: string,
        ) -> string {
            let v11: string = Documents::method178(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.hangul"),
                v11
            ))
        }
        pub fn closure81(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v7: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method177(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method12(),
                    v1_1,
                    length(v2),
                    v0_1,
                ))
            };
        }
        pub fn method171(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US36 {
            let v15: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v60: Vec<u8> = Documents::method172(v15.unwrap());
            let v62: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v60);
            let v66: std::string::String = v62.unwrap();
            let v109: Array<string> = split(
                fable_library_rust::String_::fromString(v66),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v112: i32 = get_Count(v109.clone());
            let v113: Array<string> = new_init(&string(""), v112);
            let v114: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method63(v112, v114.clone()) {
                let v116: i32 = v114.l0.get().clone();
                let v120: string = trim(v109[v116].clone());
                v113.get_mut()[v116 as usize] = v120;
                {
                    let v123: i32 = (v116) + 1_i32;
                    v114.l0.set(v123);
                    ()
                }
            }
            {
                let v124: i32 = get_Count(v113.clone());
                let v125: Array<string> = new_init(&string(""), v124);
                let v126: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method173(v124, v126.clone()) {
                    let v128: i32 = v126.l0.get().clone();
                    let v129: i32 = v126.l1.get().clone();
                    let v130: string = v113[v128].clone();
                    let v138: i32 = if (v130.clone()) != string("") {
                        v125.get_mut()[v129 as usize] = v130;
                        (v129) + 1_i32
                    } else {
                        v129
                    };
                    let v139: i32 = (v128) + 1_i32;
                    v126.l0.set(v139);
                    v126.l1.set(v138);
                    ()
                }
                {
                    let v140: i32 = v126.l1.get().clone();
                    let v141: Array<string> = new_init(&string(""), v140);
                    let v142: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method63(v140, v142.clone()) {
                        let v144: i32 = v142.l0.get().clone();
                        let v145: string = v125[v144].clone();
                        v141.get_mut()[v144 as usize] = v145;
                        {
                            let v146: i32 = (v144) + 1_i32;
                            v142.l0.set(v146);
                            ()
                        }
                    }
                    {
                        let _let__v150: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v141 = v141.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v141 = v141.clone();
                                        move |i: i32| v141[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v141.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v166: string = concat(new_array(&[
                            join(Documents::method136(), toArray_1(_let__v150)),
                            string("\n\n"),
                        ]));
                        let patternInput: (i32, string) = Documents::method83(
                            concat(new_array(&[
                                Documents::method28(
                                    v0_1,
                                    concat(new_array(&[
                                        string(
                                            "../alphabet/deps/hangulize/cmd/hangulize/hangulize",
                                        ),
                                        if cfg!(windows) {
                                            string(".exe")
                                        } else {
                                            string("")
                                        },
                                    ])),
                                ),
                                string(" "),
                                v1_1,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v166 = v166.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure80(v166.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v215: i32 = patternInput.0.clone();
                        let v218: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v221: i32 = get_Count(v218.clone());
                        let v223: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method176(v124, v223.clone()) {
                            let v225: i32 = v223.l0.get().clone();
                            let matchValue: string = v223.l1.get().clone();
                            let matchValue_1: i32 = v223.l2.get().clone();
                            let v228: i32 = v223.l3.get().clone();
                            let v227: i32 = matchValue_1;
                            let v226: string = matchValue;
                            let v229: string = v113[v225].clone();
                            let patternInput_2: (string, i32, i32) = if (v229.clone()) == string("")
                            {
                                (
                                    concat(new_array(&[v226.clone(), string("\n")])),
                                    (v227) + 1_i32,
                                    (v228) + 1_i32,
                                )
                            } else {
                                let v234: i32 = (v227) - (v228);
                                (
                                    if (v234) >= (v221) {
                                        v226.clone()
                                    } else {
                                        let v237: string = v218[v234].clone();
                                        let v245: string = if contains(v237.clone(), string("://"))
                                        {
                                            v229
                                        } else {
                                            v237
                                        };
                                        if (v234) == ((v221) - 1_i32) {
                                            concat(new_array(&[v226.clone(), v245.clone()]))
                                        } else {
                                            concat(new_array(&[v226, v245, string("\n")]))
                                        }
                                    },
                                    (v227) + 1_i32,
                                    v228,
                                )
                            };
                            let v256: i32 = (v225) + 1_i32;
                            v223.l0.set(v256);
                            v223.l1.set(patternInput_2.0.clone());
                            v223.l2.set(patternInput_2.1.clone());
                            v223.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v223.l1.get().clone();
                            let matchValue_4: i32 = v223.l2.get().clone();
                            let matchValue_5: i32 = v223.l3.get().clone();
                            let v257: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v257.clone()).unwrap();
                            {
                                let v264: () = {
                                    Documents::closure81(v2, v215, v257.clone(), ());
                                    ()
                                };
                                Documents::US36::US36_0(v215, v257)
                            }
                        }
                    }
                }
            }
        }
        pub fn method180(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v31: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v40: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v50: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v60: () = {
                Documents::closure8(v3.clone(), string("result"), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v78: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v88: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method179(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Documents::method180(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.files_fn / error"),
                v10
            ))
        }
        pub fn closure82(v0_1: string, v1_1: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v6: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method179(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure79(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US33 {
            let patternInput: (string, string) = Documents::method158(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if (Documents::method30(v6.clone())) == false {
                true
            } else {
                (Documents::method30(v7.clone())) == false
            } {
                false
            } else {
                let v13: string = Documents::method38(v6.clone());
                let v15: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v13);
                let v19: std::fs::File = v15.unwrap();
                let v32: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v19);
                let v34: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v32);
                let v36: bool = true;
                let mut v34 = v34;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v39: sha2::Sha256 = result;
                    let v41: bool = true;
                    let mut v39 = v39;
                    let v43: usize = 0_i32 as usize;
                    let v47: _ = [0_u8; 1024];
                    let v49: bool = true;
                    loop {
                        // rust.loop;
                        let v51: bool = true;
                        let mut v47 = v47;
                        let v53: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v34, &mut v47);
                        let v66: usize = v53.unwrap();
                        if (v66) == (v43) {
                            let v74: bool = true;
                            break;
                            ()
                        }
                        {
                            let v76: usize = v66;
                            let v93: &_ = if (v76) == (v47.len()) {
                                &v47[v43..]
                            } else {
                                &v47[v43..v76]
                            };
                            sha2::Digest::update(&mut v39, v93);
                            {
                                let v96: bool = true;
                            } // rust.loop;
                            let v98: bool = true;
                        } // rust.loop;
                        let v100: bool = true;
                    } // rust.loop;
                    let v102: bool = true;
                    {
                        // rust.loop;
                        let v104: bool = true;
                        {
                            // rust.loop;
                            let v106: &[u8] = &sha2::Digest::finalize(v39);
                            let v108: Vec<u8> = v106.iter().map(|x| *x).collect::<Vec<_>>();
                            let v110: bool = true;
                            let _vec_map: Vec<_> = v108
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v112: u8 = x;
                                    let v114: std::string::String = format!("{:02x}", v112);
                                    let v116: string =
                                        fable_library_rust::String_::fromString(v114);
                                    let v118: bool = true;
                                    v116
                                })
                                .collect::<Vec<_>>();
                            let v120: Vec<string> = _vec_map;
                            let v122: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v120.clone());
                            let _let__v126: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v122 = v122.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v122 = v122.clone();
                                                move |i: i32| v122[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v122.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v135: string = Documents::method159();
                            let v142: string = join(
                                if (v135.clone()) == string("\n") {
                                    Documents::method65(v135.clone())
                                } else {
                                    v135
                                },
                                toArray_1(_let__v126),
                            );
                            let v146 = Documents::method69();
                            let v150: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v142).map_err(|x| v146(x));
                            let v162 = Documents::method160();
                            let v163 = Documents::method161();
                            let v165: Documents::US34 = match v150 {
                                Ok(x) => v162(x),
                                Err(e) => v163(e),
                            };
                            let v174: string = match &v165 {
                                Documents::US34::US34_0(v165_0_0) => v165_0_0.clone(),
                                Documents::US34::US34_1(v165_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v165_1_0.clone()
                                    ),
                                ),
                            };
                            let v175: string = Documents::method38(v7.clone());
                            let v177: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v175);
                            let v181: std::fs::File = v177.unwrap();
                            let v194: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v181);
                            let v196: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v194);
                            let v198: bool = true;
                            let mut v196 = v196;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v201: sha2::Sha256 = result;
                                let v203: bool = true;
                                let mut v201 = v201;
                                let v205: usize = 0_i32 as usize;
                                let v209: _ = [0_u8; 1024];
                                let v211: bool = true;
                                loop {
                                    // rust.loop;
                                    let v213: bool = true;
                                    let mut v209 = v209;
                                    let v215: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v196, &mut v209);
                                    let v228: usize = v215.unwrap();
                                    if (v228) == (v205) {
                                        let v236: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v238: usize = v228;
                                        let v255: &_ = if (v238) == (v209.len()) {
                                            &v209[v205..]
                                        } else {
                                            &v209[v205..v238]
                                        };
                                        sha2::Digest::update(&mut v201, v255);
                                        {
                                            let v258: bool = true;
                                        } // rust.loop;
                                        let v260: bool = true;
                                    } // rust.loop;
                                    let v262: bool = true;
                                } // rust.loop;
                                let v264: bool = true;
                                {
                                    // rust.loop;
                                    let v266: bool = true;
                                    {
                                        // rust.loop;
                                        let v268: &[u8] = &sha2::Digest::finalize(v201);
                                        let v270: Vec<u8> =
                                            v268.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v272: bool = true;
                                        let _vec_map: Vec<_> = v270
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v274: u8 = x;
                                                let v276: std::string::String =
                                                    format!("{:02x}", v274);
                                                let v278: string =
                                                    fable_library_rust::String_::fromString(v276);
                                                let v280: bool = true;
                                                v278
                                            })
                                            .collect::<Vec<_>>();
                                        let v282: Vec<string> = _vec_map;
                                        let v284: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v282.clone(),
                                            );
                                        let _let__v288: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v284 = v284.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v284 = v284.clone();
                                                            move |i_1: i32| v284[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v284.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v297: string = Documents::method159();
                                        let v304: string = join(
                                            if (v297.clone()) == string("\n") {
                                                Documents::method65(v297.clone())
                                            } else {
                                                v297
                                            },
                                            toArray_1(_let__v288),
                                        );
                                        let v308 = Documents::method69();
                                        let v312: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v304).map_err(|x| v308(x));
                                        let v324 = Documents::method160();
                                        let v325 = Documents::method161();
                                        let v327: Documents::US34 = match v312 {
                                            Ok(x) => v324(x),
                                            Err(e) => v325(e),
                                        };
                                        (v174)
                                            == (match &v327 {
                                                Documents::US34::US34_0(v327_0_0) => {
                                                    v327_0_0.clone()
                                                }
                                                Documents::US34::US34_1(v327_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v327_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US33::US33_1
            } else {
                let v340: Documents::US36 = Documents::method171(v2, v3, v6.clone(), v4);
                match &v340 {
                    Documents::US36::US36_0(v340_0_0, v340_0_1) => {
                        let v342: string = v340_0_1.clone();
                        let v341: i32 = v340_0_0.clone();
                        if (v341) != 0_i32 {
                            let v349: () = {
                                Documents::closure82(v342.clone(), v341, ());
                                ()
                            };
                            Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v342)),
                            ))
                        } else {
                            if Documents::method30(v6.clone()) {
                                Documents::method164(v7.clone(), v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v6.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US33::US33_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US36::US36_1(v340_1_0, v340_1_1) => {
                        Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v340_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure78(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US33> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure79(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v,
                    )
                }
            })
        }
        pub fn method183(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v32: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v51: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v98: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v107: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v116: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v126: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method182(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
        ) -> string {
            let v11: string = Documents::method183(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.crowbook / result contains ERROR"),
                v11
            ))
        }
        pub fn closure85(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v7: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method182(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method35(),
                    v2,
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method181(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US36 {
            let v61: string = if string("html") == (v4.clone()) {
                string("--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
            } else {
                if string("pdf") == (v4.clone()) {
                    append((append(string("--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\""),
                                       (if (v0_1) == false {
                                            string("")
                                        } else {
                                            string(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13")
                                        }))),
                               string(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""))
                } else {
                    if string("epub") == (v4.clone()) {
                        string("--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
                    } else {
                        string("")
                    }
                }
            };
            let patternInput: (i32, string) = Documents::method83(
                append(
                    (concat(new_array(&[string("crowbook --verbose --to "), v4]))),
                    sprintf!(" --single \"{}\" --output \"{}\" {}", v2, v1_1.clone(), v61),
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3),
            );
            let v76: string = patternInput.1.clone();
            let v75: i32 = patternInput.0.clone();
            if (contains(v76.clone(), string("ERROR"))) == false {
                Documents::US36::US36_0(v75, v76.clone())
            } else {
                let v86: () = {
                    Documents::closure85(v1_1, v76.clone(), v75, ());
                    ()
                };
                Documents::US36::US36_1(v75, v76)
            }
        }
        pub fn closure84(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US33 {
            let patternInput: (string, string) = Documents::method158(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method30(v5.clone())) == false {
                true
            } else {
                (Documents::method30(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method38(v5.clone());
                let v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
                let v18: std::fs::File = v14.unwrap();
                let v31: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
                let v33: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v31);
                let v35: bool = true;
                let mut v33 = v33;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v38: sha2::Sha256 = result;
                    let v40: bool = true;
                    let mut v38 = v38;
                    let v42: usize = 0_i32 as usize;
                    let v46: _ = [0_u8; 1024];
                    let v48: bool = true;
                    loop {
                        // rust.loop;
                        let v50: bool = true;
                        let mut v46 = v46;
                        let v52: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v33, &mut v46);
                        let v65: usize = v52.unwrap();
                        if (v65) == (v42) {
                            let v73: bool = true;
                            break;
                            ()
                        }
                        {
                            let v75: usize = v65;
                            let v92: &_ = if (v75) == (v46.len()) {
                                &v46[v42..]
                            } else {
                                &v46[v42..v75]
                            };
                            sha2::Digest::update(&mut v38, v92);
                            {
                                let v95: bool = true;
                            } // rust.loop;
                            let v97: bool = true;
                        } // rust.loop;
                        let v99: bool = true;
                    } // rust.loop;
                    let v101: bool = true;
                    {
                        // rust.loop;
                        let v103: bool = true;
                        {
                            // rust.loop;
                            let v105: &[u8] = &sha2::Digest::finalize(v38);
                            let v107: Vec<u8> = v105.iter().map(|x| *x).collect::<Vec<_>>();
                            let v109: bool = true;
                            let _vec_map: Vec<_> = v107
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v111: u8 = x;
                                    let v113: std::string::String = format!("{:02x}", v111);
                                    let v115: string =
                                        fable_library_rust::String_::fromString(v113);
                                    let v117: bool = true;
                                    v115
                                })
                                .collect::<Vec<_>>();
                            let v119: Vec<string> = _vec_map;
                            let v121: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v119.clone());
                            let _let__v125: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v121 = v121.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v121 = v121.clone();
                                                move |i: i32| v121[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v121.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v134: string = Documents::method159();
                            let v141: string = join(
                                if (v134.clone()) == string("\n") {
                                    Documents::method65(v134.clone())
                                } else {
                                    v134
                                },
                                toArray_1(_let__v125),
                            );
                            let v145 = Documents::method69();
                            let v149: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v141).map_err(|x| v145(x));
                            let v161 = Documents::method160();
                            let v162 = Documents::method161();
                            let v164: Documents::US34 = match v149 {
                                Ok(x) => v161(x),
                                Err(e) => v162(e),
                            };
                            let v173: string = match &v164 {
                                Documents::US34::US34_0(v164_0_0) => v164_0_0.clone(),
                                Documents::US34::US34_1(v164_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v164_1_0.clone()
                                    ),
                                ),
                            };
                            let v174: string = Documents::method38(v6.clone());
                            let v176: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v174);
                            let v180: std::fs::File = v176.unwrap();
                            let v193: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v180);
                            let v195: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v193);
                            let v197: bool = true;
                            let mut v195 = v195;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v200: sha2::Sha256 = result;
                                let v202: bool = true;
                                let mut v200 = v200;
                                let v204: usize = 0_i32 as usize;
                                let v208: _ = [0_u8; 1024];
                                let v210: bool = true;
                                loop {
                                    // rust.loop;
                                    let v212: bool = true;
                                    let mut v208 = v208;
                                    let v214: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v195, &mut v208);
                                    let v227: usize = v214.unwrap();
                                    if (v227) == (v204) {
                                        let v235: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v237: usize = v227;
                                        let v254: &_ = if (v237) == (v208.len()) {
                                            &v208[v204..]
                                        } else {
                                            &v208[v204..v237]
                                        };
                                        sha2::Digest::update(&mut v200, v254);
                                        {
                                            let v257: bool = true;
                                        } // rust.loop;
                                        let v259: bool = true;
                                    } // rust.loop;
                                    let v261: bool = true;
                                } // rust.loop;
                                let v263: bool = true;
                                {
                                    // rust.loop;
                                    let v265: bool = true;
                                    {
                                        // rust.loop;
                                        let v267: &[u8] = &sha2::Digest::finalize(v200);
                                        let v269: Vec<u8> =
                                            v267.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v271: bool = true;
                                        let _vec_map: Vec<_> = v269
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v273: u8 = x;
                                                let v275: std::string::String =
                                                    format!("{:02x}", v273);
                                                let v277: string =
                                                    fable_library_rust::String_::fromString(v275);
                                                let v279: bool = true;
                                                v277
                                            })
                                            .collect::<Vec<_>>();
                                        let v281: Vec<string> = _vec_map;
                                        let v283: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v281.clone(),
                                            );
                                        let _let__v287: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v283 = v283.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v283 = v283.clone();
                                                            move |i_1: i32| v283[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v283.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v296: string = Documents::method159();
                                        let v303: string = join(
                                            if (v296.clone()) == string("\n") {
                                                Documents::method65(v296.clone())
                                            } else {
                                                v296
                                            },
                                            toArray_1(_let__v287),
                                        );
                                        let v307 = Documents::method69();
                                        let v311: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v303).map_err(|x| v307(x));
                                        let v323 = Documents::method160();
                                        let v324 = Documents::method161();
                                        let v326: Documents::US34 = match v311 {
                                            Ok(x) => v323(x),
                                            Err(e) => v324(e),
                                        };
                                        (v173)
                                            == (match &v326 {
                                                Documents::US34::US34_0(v326_0_0) => {
                                                    v326_0_0.clone()
                                                }
                                                Documents::US34::US34_1(v326_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v326_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US33::US33_1
            } else {
                let v339: Documents::US36 = Documents::method181(v2, v5.clone(), v3, v1_1, v4);
                match &v339 {
                    Documents::US36::US36_0(v339_0_0, v339_0_1) => {
                        let v341: string = v339_0_1.clone();
                        let v340: i32 = v339_0_0.clone();
                        if (v340) != 0_i32 {
                            let v348: () = {
                                Documents::closure82(v341.clone(), v340, ());
                                ()
                            };
                            Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v341)),
                            ))
                        } else {
                            if Documents::method30(v5.clone()) {
                                Documents::method164(v6.clone(), v5.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v5.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US33::US33_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US36::US36_1(v339_1_0, v339_1_1) => {
                        Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v339_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure83(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US33> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure84(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method185(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v3.clone(), string("output_path"), ());
                ()
            };
            let v31: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v40: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v50: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v60: () = {
                Documents::closure8(v3.clone(), string("output_cache_path"), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v78: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v88: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method184(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Documents::method185(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / par_map / files\' = [] / listm.iter"),
                v10
            ))
        }
        pub fn closure86(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v6: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method184(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method186(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<LrcPtr<Documents::UH5>>,
        ) -> List<LrcPtr<Documents::UH5>> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH4::UH4_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method186(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure88(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: LrcPtr<Documents::UH4>,
        ) -> LrcPtr<Documents::UH4> {
            LrcPtr::new(Documents::UH4::UH4_1(v0_1, v1_1))
        }
        pub fn closure87(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH5>,
        ) -> Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH4>| Documents::closure88(v0_1.clone(), v)
            })
        }
        pub fn method187(
        ) -> Func1<LrcPtr<Documents::UH5>, Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH5>| Documents::closure87((), v))
        }
        pub fn method189(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US33>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US33>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH5::UH5_0 => v1_1.clone(),
                Documents::UH5::UH5_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, x, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            move |a0: string| {
                                Func1::new({
                                    let a0 = a0.clone();
                                    let v0_1 = v0_1.clone();
                                    move |a1: string| {
                                        (match v0_1.as_ref() {
                                            Documents::UH5::UH5_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method189(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure89(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US33>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US33 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US33::US33_0(v4_0_0) => Some(
                    match &v4 {
                        Documents::US33::US33_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method190(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method191(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method188(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH4>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method188: loop {
                break '_method188 (match v0_1.get().clone().as_ref() {
                    Documents::UH4::UH4_0 => v1_1.get().clone(),
                    Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => {
                        let v8 = toArray(Documents::method189(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH4::UH4_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US33>>,
                            )>(),
                        ));
                        let v12 = v8.to_vec();
                        let v14 = rayon::iter::IntoParallelIterator::into_par_iter(v12);
                        let v17 = rayon::iter::ParallelIterator::map(v14, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US33>>,
                                )| {
                                    Documents::closure89((), arg10_0040)
                                },
                            )(x)
                        });
                        let v20: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method190(rayon::iter::ParallelIterator::collect(v17));
                        let v21: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method191(v1_1.get().clone());
                        let v23: bool = true;
                        let mut v21 = v21;
                        let v25: bool = true;
                        v21.extend(v20);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH4::UH4_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v21;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method188;
                        }
                    }
                });
            }
        }
        pub fn closure35(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Result<
            LrcPtr<(
                string,
                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            )>,
            std::string::String,
        > {
            let v6: string = Documents::method61(v5);
            let v13: &str = &*v6.clone();
            let v46: std::string::String = String::from(v13);
            let v79: std::path::PathBuf = std::path::PathBuf::from(v46);
            let v112: std::path::Display = v79.display();
            let v145: std::string::String = format!("{}", v112);
            let v179: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v145),
                        v3.clone(),
                        Documents::method81(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v180: string = Documents::method38(v6);
            let v182: string = Documents::method82(Documents::method28(v2.clone(), v179.clone()));
            let patternInput: (i32, string) = Documents::method83(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v182.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v195: string = patternInput.1.clone();
            let v194: i32 = patternInput.0.clone();
            let v197: string = Documents::method82(Documents::method28(v3.clone(), v179.clone()));
            let patternInput_1: (i32, string) = Documents::method83(
                concat(new_array(&[
                    string("git hash-object \""),
                    v197.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v210: string = patternInput_1.1.clone();
            let v209: i32 = patternInput_1.0.clone();
            let v212: string = Documents::method82(Documents::method28(v4.clone(), v179.clone()));
            let v214: string =
                (Documents::method158(string("hangul.md"), v197.clone(), v4.clone()))
                    .0
                    .clone();
            let v715: LrcPtr<Documents::UH4> = if contains(v195.clone(), v210.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v227: string = Documents::method38(v197.clone());
                let v229: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v227);
                let v233: std::fs::File = v229.unwrap();
                let v246: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v233);
                let v248: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v246);
                let v250: bool = true;
                let mut v248 = v248;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v253: sha2::Sha256 = result;
                    let v255: bool = true;
                    let mut v253 = v253;
                    let v257: usize = 0_i32 as usize;
                    let v261: _ = [0_u8; 1024];
                    let v263: bool = true;
                    loop {
                        // rust.loop;
                        let v265: bool = true;
                        let mut v261 = v261;
                        let v267: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v248, &mut v261);
                        let v280: usize = v267.unwrap();
                        if (v280) == (v257) {
                            let v288: bool = true;
                            break;
                            ()
                        }
                        {
                            let v290: usize = v280;
                            let v307: &_ = if (v290) == (v261.len()) {
                                &v261[v257..]
                            } else {
                                &v261[v257..v290]
                            };
                            sha2::Digest::update(&mut v253, v307);
                            {
                                let v310: bool = true;
                            } // rust.loop;
                            let v312: bool = true;
                        } // rust.loop;
                        let v314: bool = true;
                    } // rust.loop;
                    let v316: bool = true;
                    {
                        // rust.loop;
                        let v318: bool = true;
                        {
                            // rust.loop;
                            let v320: &[u8] = &sha2::Digest::finalize(v253);
                            let v322: Vec<u8> = v320.iter().map(|x| *x).collect::<Vec<_>>();
                            let v324: bool = true;
                            let _vec_map: Vec<_> = v322
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v326: u8 = x;
                                    let v328: std::string::String = format!("{:02x}", v326);
                                    let v330: string =
                                        fable_library_rust::String_::fromString(v328);
                                    let v332: bool = true;
                                    v330
                                })
                                .collect::<Vec<_>>();
                            let v334: Vec<string> = _vec_map;
                            let v336: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v334.clone());
                            let _let__v340: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v336 = v336.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v336 = v336.clone();
                                                move |i: i32| v336[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v336.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v349: string = Documents::method159();
                            let v356: string = join(
                                if (v349.clone()) == string("\n") {
                                    Documents::method65(v349.clone())
                                } else {
                                    v349
                                },
                                toArray_1(_let__v340),
                            );
                            let v360 = Documents::method69();
                            let v364: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v356).map_err(|x| v360(x));
                            let v376 = Documents::method160();
                            let v377 = Documents::method161();
                            let v379: Documents::US34 = match v364 {
                                Ok(x) => v376(x),
                                Err(e) => v377(e),
                            };
                            let v388: string = match &v379 {
                                Documents::US34::US34_0(v379_0_0) => v379_0_0.clone(),
                                Documents::US34::US34_1(v379_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v379_1_0.clone()
                                    ),
                                ),
                            };
                            let v551: Documents::US5 = if (Documents::method30(v212.clone()))
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v392: string = Documents::method38(v212.clone());
                                let v394: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v392);
                                let v398: std::fs::File = v394.unwrap();
                                let v411: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v398);
                                let v413: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v411);
                                let v415: bool = true;
                                let mut v413 = v413;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v418: sha2::Sha256 = result;
                                    let v420: bool = true;
                                    let mut v418 = v418;
                                    let v422: usize = 0_i32 as usize;
                                    let v426: _ = [0_u8; 1024];
                                    let v428: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v430: bool = true;
                                        let mut v426 = v426;
                                        let v432: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v413, &mut v426);
                                        let v445: usize = v432.unwrap();
                                        if (v445) == (v422) {
                                            let v453: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v455: usize = v445;
                                            let v472: &_ = if (v455) == (v426.len()) {
                                                &v426[v422..]
                                            } else {
                                                &v426[v422..v455]
                                            };
                                            sha2::Digest::update(&mut v418, v472);
                                            {
                                                let v475: bool = true;
                                            } // rust.loop;
                                            let v477: bool = true;
                                        } // rust.loop;
                                        let v479: bool = true;
                                    } // rust.loop;
                                    let v481: bool = true;
                                    {
                                        // rust.loop;
                                        let v483: bool = true;
                                        {
                                            // rust.loop;
                                            let v485: &[u8] = &sha2::Digest::finalize(v418);
                                            let v487: Vec<u8> =
                                                v485.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v489: bool = true;
                                            let _vec_map: Vec<_> = v487
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v491: u8 = x;
                                                    let v493: std::string::String =
                                                        format!("{:02x}", v491);
                                                    let v495: string =
                                                        fable_library_rust::String_::fromString(
                                                            v493,
                                                        );
                                                    let v497: bool = true;
                                                    v495
                                                })
                                                .collect::<Vec<_>>();
                                            let v499: Vec<string> = _vec_map;
                                            let v501: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(
                                                    v499.clone(),
                                                );
                                            let _let__v505: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v501 = v501.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v501 = v501.clone();
                                                                move |i_1: i32| v501[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                (get_Count(v501.clone())) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v514: string = Documents::method159();
                                            let v521: string = join(
                                                if (v514.clone()) == string("\n") {
                                                    Documents::method65(v514.clone())
                                                } else {
                                                    v514
                                                },
                                                toArray_1(_let__v505),
                                            );
                                            let v525 = Documents::method69();
                                            let v529: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v521)
                                                    .map_err(|x| v525(x));
                                            let v541 = Documents::method160();
                                            let v542 = Documents::method161();
                                            let v544: Documents::US34 = match v529 {
                                                Ok(x) => v541(x),
                                                Err(e) => v542(e),
                                            };
                                            match &v544 {
                                                Documents::US34::US34_0(v544_0_0) => {
                                                    Documents::US5::US5_0(v544_0_0.clone())
                                                }
                                                _ => Documents::US5::US5_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US5::US5_0(v551_0_0) = &v551 {
                                if (v388.clone()) == (v551_0_0.clone()) {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v557: () = {
                                        Documents::closure73(
                                            v179.clone(),
                                            v180.clone(),
                                            v182.clone(),
                                            v195.clone(),
                                            v194,
                                            v197.clone(),
                                            v210.clone(),
                                            v209,
                                            v212.clone(),
                                            v388.clone(),
                                            v551.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method164(v212.clone(), v197.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v197.clone(),
                                            Func2::new({
                                                let v0_1 = v0_1.clone();
                                                let v1_1 = v1_1.clone();
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v1_1 = v1_1.clone();
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v: string| {
                                                            Documents::closure78(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                v1_1.clone(),
                                                                v0_1.clone(),
                                                                v,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH5::UH5_0),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("html"),
                                                v197.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure83(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_1,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("pdf"),
                                                    v197.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure83(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_2,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("epub"),
                                                        v197.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure83(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            false,
                                                                            v_3,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("html"),
                                                            v214.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure83(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_4,
                                                                            )
                                                                        }
                                                                    }))(
                                                                        b0
                                                                    )(
                                                                        b1
                                                                    )
                                                                }
                                                            }),
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("pdf"),
                                                                v214.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure83(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_5,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                                    string("epub"),
                                                                    v214.clone(),
                                                                    Func2::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move
                                                                                                                                                                                                                                                                                                                                           |b0:
                                                                                                                                                                                                                                                                                                                                                string,
                                                                                                                                                                                                                                                                                                                                            b1:
                                                                                                                                                                                                                                                                                                                                                string|
                                                                                                                                                                                                                                                                                                                                           (Func1::new({
                                                                                                                                                                                                                                                                                                                                                           let v3
                                                                                                                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                                                                                                                               v3.clone();
                                                                                                                                                                                                                                                                                                                                                           let v4
                                                                                                                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                                                                                                                               v4.clone();
                                                                                                                                                                                                                                                                                                                                                           move
                                                                                                                                                                                                                                                                                                                                                               |v_6:
                                                                                                                                                                                                                                                                                                                                                                    string|
                                                                                                                                                                                                                                                                                                                                                               Documents::closure83(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    true,
                                                                                                                                                                                                                                                                                                                                                                                    v_6)
                                                                                                                                                                                                                                                                                                                                                       }))(b0)(b1)
                                                                    }),
                                                                    LrcPtr::new(
                                                                        Documents::UH5::UH5_0,
                                                                    ),
                                                                )),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                            LrcPtr::new(Documents::UH4::UH4_0),
                                        )),
                                    ))
                                }
                            } else {
                                let v637: () = {
                                    Documents::closure73(
                                        v179,
                                        v180.clone(),
                                        v182,
                                        v195,
                                        v194,
                                        v197.clone(),
                                        v210,
                                        v209,
                                        v212.clone(),
                                        v388,
                                        v551.clone(),
                                        (),
                                    );
                                    ()
                                };
                                Documents::method164(v212, v197.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v197.clone(),
                                        Func2::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v1_1 = v1_1.clone();
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_7: string| {
                                                        Documents::closure78(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            v1_1.clone(),
                                                            v0_1.clone(),
                                                            v_7,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH5::UH5_0),
                                    )),
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("html"),
                                            v197.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_8: string| {
                                                            Documents::closure83(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                false,
                                                                v_8,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("pdf"),
                                                v197.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_9: string| {
                                                                Documents::closure83(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_9,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("epub"),
                                                    v197.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_10: string| {
                                                                    Documents::closure83(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_10,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("html"),
                                                        v214.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_11: string| {
                                                                        Documents::closure83(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            true,
                                                                            v_11,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("pdf"),
                                                            v214.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_12: string| {
                                                                            Documents::closure83(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_12,
                                                                            )
                                                                        }
                                                                    }))(
                                                                        b0
                                                                    )(
                                                                        b1
                                                                    )
                                                                }
                                                            }),
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("epub"),
                                                                v214.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_13: string| {
                                                                                Documents::closure83(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_13,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                LrcPtr::new(Documents::UH5::UH5_0),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_0),
                                    )),
                                ))
                            }
                        }
                    }
                }
            };
            let v1146: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method186(
                if (if let Documents::UH4::UH4_0 = v715.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v715
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method158(string("epub"), v214.clone(), v4.clone());
                    let v720: string = patternInput_3.1.clone();
                    let v719: string = patternInput_3.0.clone();
                    let v779: LrcPtr<Documents::UH5> = if if Documents::method30(v719.clone()) {
                        true
                    } else {
                        if (Documents::method30(v720.clone())) == false {
                            true
                        } else {
                            let v726: () = {
                                Documents::closure86(v720.clone(), v719.clone(), ());
                                ()
                            };
                            Documents::method164(v719, v720);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v214.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_14: string| {
                                            Documents::closure83(v4.clone(), v3.clone(), true, v_14)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            LrcPtr::new(Documents::UH5::UH5_0),
                        ))
                    } else {
                        LrcPtr::new(Documents::UH5::UH5_0)
                    };
                    let patternInput_4: (string, string) =
                        Documents::method158(string("pdf"), v214.clone(), v4.clone());
                    let v782: string = patternInput_4.1.clone();
                    let v781: string = patternInput_4.0.clone();
                    let v839: LrcPtr<Documents::UH5> = if if Documents::method30(v781.clone()) {
                        true
                    } else {
                        if (Documents::method30(v782.clone())) == false {
                            true
                        } else {
                            let v788: () = {
                                Documents::closure86(v782.clone(), v781.clone(), ());
                                ()
                            };
                            Documents::method164(v781, v782);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v214.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_15: string| {
                                            Documents::closure83(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v779.clone(),
                        ))
                    } else {
                        v779
                    };
                    let patternInput_5: (string, string) =
                        Documents::method158(string("html"), v214.clone(), v4.clone());
                    let v842: string = patternInput_5.1.clone();
                    let v841: string = patternInput_5.0.clone();
                    let v899: LrcPtr<Documents::UH5> = if if Documents::method30(v841.clone()) {
                        true
                    } else {
                        if (Documents::method30(v842.clone())) == false {
                            true
                        } else {
                            let v848: () = {
                                Documents::closure86(v842.clone(), v841.clone(), ());
                                ()
                            };
                            Documents::method164(v841, v842);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v214,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_16: string| {
                                            Documents::closure83(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v839.clone(),
                        ))
                    } else {
                        v839
                    };
                    let patternInput_6: (string, string) =
                        Documents::method158(string("epub"), v197.clone(), v4.clone());
                    let v901: string = patternInput_6.1.clone();
                    let v900: string = patternInput_6.0.clone();
                    let v958: LrcPtr<Documents::UH5> = if if Documents::method30(v900.clone()) {
                        true
                    } else {
                        if (Documents::method30(v901.clone())) == false {
                            true
                        } else {
                            let v907: () = {
                                Documents::closure86(v901.clone(), v900.clone(), ());
                                ()
                            };
                            Documents::method164(v900, v901);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v197.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_17: string| {
                                            Documents::closure83(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v899.clone(),
                        ))
                    } else {
                        v899
                    };
                    let patternInput_7: (string, string) =
                        Documents::method158(string("pdf"), v197.clone(), v4.clone());
                    let v960: string = patternInput_7.1.clone();
                    let v959: string = patternInput_7.0.clone();
                    let v1017: LrcPtr<Documents::UH5> = if if Documents::method30(v959.clone()) {
                        true
                    } else {
                        if (Documents::method30(v960.clone())) == false {
                            true
                        } else {
                            let v966: () = {
                                Documents::closure86(v960.clone(), v959.clone(), ());
                                ()
                            };
                            Documents::method164(v959, v960);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v197.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_18: string| {
                                            Documents::closure83(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v958.clone(),
                        ))
                    } else {
                        v958
                    };
                    let patternInput_8: (string, string) =
                        Documents::method158(string("html"), v197.clone(), v4.clone());
                    let v1019: string = patternInput_8.1.clone();
                    let v1018: string = patternInput_8.0.clone();
                    let v1076: LrcPtr<Documents::UH5> = if if Documents::method30(v1018.clone()) {
                        true
                    } else {
                        if (Documents::method30(v1019.clone())) == false {
                            true
                        } else {
                            let v1025: () = {
                                Documents::closure86(v1019.clone(), v1018.clone(), ());
                                ()
                            };
                            Documents::method164(v1018, v1019);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v197.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_19: string| {
                                            Documents::closure83(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v1017.clone(),
                        ))
                    } else {
                        v1017
                    };
                    let patternInput_9: (string, string) =
                        Documents::method158(string("hangul.md"), v197.clone(), v4.clone());
                    let v1078: string = patternInput_9.1.clone();
                    let v1077: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method30(v1077.clone()) {
                            true
                        } else {
                            if (Documents::method30(v1078.clone())) == false {
                                true
                            } else {
                                let v1084: () = {
                                    Documents::closure86(v1078.clone(), v1077.clone(), ());
                                    ()
                                };
                                Documents::method164(v1077, v1078);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v197,
                                Func2::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_20: string| {
                                                Documents::closure78(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    v1_1.clone(),
                                                    v0_1.clone(),
                                                    v_20,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH5::UH5_0),
                            ))
                        } else {
                            LrcPtr::new(Documents::UH5::UH5_0)
                        },
                        LrcPtr::new(Documents::UH4::UH4_1(
                            v1076,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v1150: Vec<LrcPtr<Documents::UH5>> = v1146.to_vec();
            let v1153: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v1157: List<LrcPtr<Documents::UH5>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v1150.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v180,
                Documents::method188(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH5>, b1: LrcPtr<Documents::UH4>| {
                                (Documents::method187())(b0)(b1)
                            },
                        ),
                        v1157,
                        LrcPtr::new(Documents::UH4::UH4_0),
                    ),
                    v1153,
                ),
            )))
        }
        pub fn method25(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                    Output = Result<
                        Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        >,
                        std::string::String,
                    >,
                >,
            >,
        > {
            let v5: Documents::US5 = Documents::method27(Documents::method26());
            let v11: Documents::US5 = match &v5 {
                Documents::US5::US5_0(v5_0_0) => Documents::US5::US5_0(
                    match &v5 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method27(string(
                    "c:\\home\\git\\polyglot\\target\\Builder\\documents",
                )),
            };
            let v17: Documents::US5 = match &v11 {
                Documents::US5::US5_0(v11_0_0) => Documents::US5::US5_0(
                    match &v11 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method27(string("/workspaces")),
            };
            let v21: string = match &v17 {
                Documents::US5::US5_0(v17_0_0) => match &v17 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v36: string = Documents::method28(
                if string("deps") == (Documents::method47(v21.clone())) {
                    let v29: Documents::US5 =
                        Documents::method27(Documents::method33(v21.clone()).clone().unwrap());
                    match &v29 {
                        Documents::US5::US5_0(v29_0_0) => match &v29 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => panic!("{}", string("Option does not have a value."),),
                    }
                } else {
                    v21
                },
                string("polyglot"),
            );
            let v37: string = Documents::method61(v3);
            let v38: string = Documents::method61(v2);
            let v39: string = Documents::method61(v1_1);
            let v42: () = {
                Documents::closure24(v0_1.clone(), v37.clone(), v38.clone(), v39.clone(), ());
                ()
            };
            let v90: bool = true;
            let __future_init = Box::pin(
                /*;
                let v92: bool = */
                async move {
                    /*;
                    let v94: bool = */
                    ();
                    let v96: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v38.clone());
                    let v99: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v96, move |x| {
                            Func1::new(move |v: async_walkdir::DirEntry| {
                                Documents::closure25((), v)
                            })(x)
                        });
                    let v100 = Documents::method72();
                    let v102 = futures::stream::StreamExt::filter_map(v99, |x| async { v100(x) });
                    let v104: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v102));
                    let v106: Vec<string> = v104.await;
                    let v109: () = {
                        Documents::closure34(v106.clone(), ());
                        ()
                    };
                    let v159: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v106);
                    let v162: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v159, |x| {
                            Func1::new({
                                let v0_1 = v0_1.clone();
                                let v36 = v36.clone();
                                let v37 = v37.clone();
                                let v38 = v38.clone();
                                let v39 = v39.clone();
                                move |v_1: string| {
                                    Documents::closure35(
                                        v0_1.clone(),
                                        v36.clone(),
                                        v37.clone(),
                                        v38.clone(),
                                        v39.clone(),
                                        v_1,
                                    )
                                }
                            })(x)
                        });
                    let v164: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v162);
                    let v168: string = string("}");
                    let v173: bool = true;
                    let _fix_closure_v170 = Ok::<
                        Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        >,
                        std::string::String,
                    >(v164);
                    let v180: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v170 "), (v168))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v181: bool = true;
                    _fix_closure_v170
                },
            ); // rust.fix_closure';
            let v183 = __future_init;
            v183
        }
        pub fn closure90(
            unitVar: (),
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
        ) -> Documents::US37 {
            Documents::US37::US37_0(v0_1)
        }
        pub fn method192() -> Func1<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            Documents::US37,
        > {
            Func1::new(
                move |v: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >| Documents::closure90((), v),
            )
        }
        pub fn closure91(unitVar: (), v0_1: std::string::String) -> Documents::US37 {
            Documents::US37::US37_1(v0_1)
        }
        pub fn method193() -> Func1<std::string::String, Documents::US37> {
            Func1::new(move |v: std::string::String| Documents::closure91((), v))
        }
        pub fn method194(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method78(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure92(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method194(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method76(),
                    v0_1,
                ))
            };
        }
        pub fn method196(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v2.clone(), string("result_len"), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v39: std::string::String = format!("{:#?}", v0_1);
            let v78: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v39), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method195(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v9: string = Documents::method196(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure93(
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_2) {
                let v5: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method195(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method12(),
                    v0_1.len(),
                ))
            };
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Documents::closure2((), ());
                ()
            };
            let v20: () = {
                Documents::closure5(v0_1, ());
                ()
            };
            let v67: clap::Command = Documents::method0();
            let v69: clap::ArgMatches = clap::Command::get_matches(v67);
            let v70: string = Documents::method20();
            let v77: &str = &*v70;
            let v105: Option<std::string::String> =
                clap::ArgMatches::get_one(&v69.clone(), v77).cloned();
            let v122: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v105));
            let v129: std::string::String = match &v122 {
                Documents::US6::US6_0(v122_0_0) => match &v122 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v131: string = fable_library_rust::String_::fromString(v129);
            let v132: string = Documents::method22();
            let v139: &str = &*v132;
            let v167: Option<std::string::String> =
                clap::ArgMatches::get_one(&v69.clone(), v139).cloned();
            let v184: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v167));
            let v191: std::string::String = match &v184 {
                Documents::US6::US6_0(v184_0_0) => match &v184 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v193: string = fable_library_rust::String_::fromString(v191);
            let v194: string = Documents::method23();
            let v201: &str = &*v194;
            let v229: Option<std::string::String> =
                clap::ArgMatches::get_one(&v69.clone(), v201).cloned();
            let v246: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v229));
            let v253: std::string::String = match &v246 {
                Documents::US6::US6_0(v246_0_0) => match &v246 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v255: string = fable_library_rust::String_::fromString(v253);
            let v256: string = Documents::method24();
            let v263: &str = &*v256;
            let v291: Option<std::string::String> = clap::ArgMatches::get_one(&v69, v263).cloned();
            let v308: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v291));
            let v315: std::string::String = match &v308 {
                Documents::US6::US6_0(v308_0_0) => match &v308 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v318: std::pin::Pin<
                Box<
                    dyn std::future::Future<
                        Output = Result<
                            Vec<
                                Result<
                                    LrcPtr<(
                                        string,
                                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                    )>,
                                    std::string::String,
                                >,
                            >,
                            std::string::String,
                        >,
                    >,
                >,
            > = Documents::method25(
                fable_library_rust::String_::fromString(v315),
                v255,
                v193,
                v131,
            );
            let v320: Result<
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
                std::string::String,
            > = futures::executor::block_on(v318);
            let v321 = Documents::method192();
            let v322 = Documents::method193();
            let v323: Documents::US37 = match &v320 {
                Err(v320_1_0) => v322(v320_1_0.clone()),
                Ok(v320_0_0) => v321(v320_0_0.clone()),
            };
            match &v323 {
                Documents::US37::US37_0(v323_0_0) => {
                    let v327: () = {
                        Documents::closure93(v323_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US37::US37_1(v323_1_0) => {
                    let v379: () = {
                        Documents::closure92(v323_1_0.clone(), ());
                        ()
                    };
                    1_i32
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Documents::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Documents::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Documents::closure1((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Documents::v1())(args)
        }
    }
}
pub use module_b8cdef03::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/async_.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/common.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/crypto.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/date_time.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/file_system.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/lib.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/networking.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/platform.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/runtime.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/sm.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/threading.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/trace.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../../deps/polyglot/lib/fsharp/Common.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Documents::main(array_from(args));
}
