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
        use fable_library_rust::List_::List;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
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
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
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
            US4_6(Documents::US3),
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
            US6_0(
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(std::string::String),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0,
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(string),
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
            US10_1(string),
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(std::path::PathBuf),
            US11_1,
        }
        impl core::fmt::Display for US11 {
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
        pub enum US12 {
            US12_0(std::fs::FileType),
            US12_1(std::string::String),
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US13 {
            US13_0,
            US13_1,
            US13_2,
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(async_walkdir::DirEntry),
            US14_1(std::string::String),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US15 {
            US15_0(string, Documents::US5),
            US15_1(string),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
        }
        impl core::fmt::Display for US16 {
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
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US16>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US18 {
            US18_0(char),
            US18_1,
        }
        impl core::fmt::Display for US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(string, LrcPtr<StringBuilder>, i32, i32),
            US19_1(string),
        }
        impl core::fmt::Display for US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(
                string,
                Documents::US5,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US20_1(string),
        }
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Documents::US18, string, LrcPtr<StringBuilder>, i32, i32),
            US21_1(string),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(Documents::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US22_1(string),
        }
        impl core::fmt::Display for US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US23 {
            US23_0(Array<string>),
            US23_1(string),
        }
        impl core::fmt::Display for US23 {
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
        pub enum US24 {
            US24_0(
                LrcPtr<Documents::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US24_1(string),
        }
        impl core::fmt::Display for US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US17>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US25_1(std::string::String),
        }
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US26_1,
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(std::string::String),
            US27_1(std::string::String),
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US28_1,
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US29_1,
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0(std::process::Output),
            US30_1(std::string::String),
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US31 {
            US31_0(i32),
            US31_1,
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US32_1,
        }
        impl core::fmt::Display for US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US33 {
            US33_0(CancellationToken),
            US33_1,
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US34 {
            US34_0(Result<string, LrcPtr<(string, string)>>),
            US34_1,
        }
        impl core::fmt::Display for US34 {
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
                Func2<string, string, Documents::US34>,
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
        pub enum US35 {
            US35_0(string),
            US35_1(std::string::String),
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0(u64),
            US36_1(std::string::String),
        }
        impl core::fmt::Display for US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US37 {
            US37_0(i32, string),
            US37_1(i32, string),
        }
        impl core::fmt::Display for US37 {
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
        pub enum US38 {
            US38_0(
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
            US38_1(std::string::String),
        }
        impl core::fmt::Display for US38 {
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
            let v3: string = Documents::method4(v0_1);
            let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v3);
            let v7: bool = true;
            let _result_map_ = v5.map(|x| {
                //;
                let v9: std::string::String = x;
                let v11: string = fable_library_rust::String_::fromString(v9);
                let v13: bool = true;
                v11
            });
            let v15: Result<string, std::env::VarError> = _result_map_;
            let v16: string = Documents::method5();
            v15.unwrap_or(v16)
        }
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v13: string = toLower(string("Warning"));
            let v20: string = toLower(string("Info"));
            let v27: string = toLower(string("Debug"));
            let v34: string = toLower(string("Verbose"));
            let v41: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v41 {
                    Documents::US1::US1_0(v41_0_0) => Documents::US1::US1_0(
                        match &v41 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v48: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v48 {
                            Documents::US1::US1_0(v48_0_0) => Documents::US1::US1_0(
                                match &v48 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v55: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v55 {
                                    Documents::US1::US1_0(v55_0_0) => Documents::US1::US1_0(
                                        match &v55 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v62: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v62 {
                                            Documents::US1::US1_0(v62_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v62 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v69: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v69 {
                                                    Documents::US1::US1_0(v69_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v69 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v76: Documents::US1 =
                                                            if (v34.clone()) == (v1_1.clone()) {
                                                                Documents::US1::US1_0(
                                                                    Documents::US0::US0_0,
                                                                )
                                                            } else {
                                                                Documents::US1::US1_1
                                                            };
                                                        match &v76 {
                                                            Documents::US1::US1_0(v76_0_0) => {
                                                                Documents::US1::US1_0(
                                                                    match &v76 {
                                                                        Documents::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v83: Documents::US1 = if (v27
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Documents::US1::US1_0(
                                                                        Documents::US0::US0_1,
                                                                    )
                                                                } else {
                                                                    Documents::US1::US1_1
                                                                };
                                                                match &v83 {
                                                                 Documents::US1::US1_0(v83_0_0)
                                                                 =>
                                                                 Documents::US1::US1_0(match &v83
                                                                                           {
                                                                                           Documents::US1::US1_0(x)
                                                                                           =>
                                                                                           x.clone(),
                                                                                           _
                                                                                           =>
                                                                                           unreachable!(),
                                                                                       }.clone()),
                                                                 _ => {
                                                                     let v90:
                                                                             Documents::US1 =
                                                                         if (v20.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Documents::US1::US1_0(Documents::US0::US0_2)
                                                                         } else {
                                                                             Documents::US1::US1_1
                                                                         };
                                                                     match &v90
                                                                         {
                                                                         Documents::US1::US1_0(v90_0_0)
                                                                         =>
                                                                         Documents::US1::US1_0(match &v90
                                                                                                   {
                                                                                                   Documents::US1::US1_0(x)
                                                                                                   =>
                                                                                                   x.clone(),
                                                                                                   _
                                                                                                   =>
                                                                                                   unreachable!(),
                                                                                               }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v97:
                                                                                     Documents::US1 =
                                                                                 if (v13.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Documents::US1::US1_0(Documents::US0::US0_3)
                                                                                 } else {
                                                                                     Documents::US1::US1_1
                                                                                 };
                                                                             match &v97
                                                                                 {
                                                                                 Documents::US1::US1_0(v97_0_0)
                                                                                 =>
                                                                                 Documents::US1::US1_0(match &v97
                                                                                                           {
                                                                                                           Documents::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v104:
                                                                                             Documents::US1 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Documents::US1::US1_0(Documents::US0::US0_4)
                                                                                         } else {
                                                                                             Documents::US1::US1_1
                                                                                         };
                                                                                     match &v104
                                                                                         {
                                                                                         Documents::US1::US1_0(v104_0_0)
                                                                                         =>
                                                                                         Documents::US1::US1_0(match &v104
                                                                                                                   {
                                                                                                                   Documents::US1::US1_0(x)
                                                                                                                   =>
                                                                                                                   x.clone(),
                                                                                                                   _
                                                                                                                   =>
                                                                                                                   unreachable!(),
                                                                                                               }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Documents::US1::US1_1,
                                                                                     }
                                                                                 }
                                                                             }
                                                                         }
                                                                     }
                                                                 }
                                                             }
                                                            }
                                                        }
                                                    }
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
            let v185: Documents::US2 = _run_target_args__v3.1.clone();
            let v184: Documents::US1 = _run_target_args__v3.0.clone();
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
                    l0: MutCell::new(match &v184 {
                        Documents::US1::US1_0(v184_0_0) => match &v184 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v185 {
                    Documents::US2::US2_0(v185_0_0) => Some(match &v185 {
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
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure7((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v241: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method8(), v5));
            let v395: DateTime = match &v241 {
                Documents::US2::US2_0(v241_0_0) => {
                    let v324: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v241 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v324.hours(),
                        v324.minutes(),
                        v324.seconds(),
                        v324.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v396: string = Documents::method9();
            let provider: string = if (v396.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v396
            };
            v395.toString(provider)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v4: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method12(v0_1: char) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Info")), 0_i32));
            let v27: &str = inline_colorization::color_bright_green;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method16(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("args"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v95: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method17(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
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
            let v9: string = Documents::method16(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v9),
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
            let v4: () = {
                Documents::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method15(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method11(),
                    v0_1,
                );
                let v140: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method18() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US7 {
            Documents::US7::US7_0(v0_1)
        }
        pub fn method19() -> Func1<std::string::String, Documents::US7> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method20() -> string {
            string("dist-dir")
        }
        pub fn method21() -> string {
            string("cache-dir")
        }
        pub fn method22() -> string {
            string("hangul-spec")
        }
        pub fn method24() -> string {
            let v6: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v10: std::path::PathBuf = v6.unwrap();
            let v28: std::path::Display = v10.display();
            let v64: std::string::String = format!("{}", v28);
            fable_library_rust::String_::fromString(v64)
        }
        pub fn method26(v0_1: string, v1_1: string) -> string {
            let v13: &str = &*v0_1;
            let v49: std::string::String = String::from(v13);
            let v85: std::path::PathBuf = std::path::PathBuf::from(v49);
            let v121: &str = &*v1_1;
            let v157: std::string::String = String::from(v121);
            let v188: std::path::PathBuf = v85.join(v157);
            let v195: std::path::Display = v188.display();
            let v231: std::string::String = format!("{}", v195);
            fable_library_rust::String_::fromString(v231)
        }
        pub fn method28(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v105: std::path::PathBuf = std::path::PathBuf::from(v48);
            if v105.clone().exists() {
                v105.is_file()
            } else {
                false
            }
        }
        pub fn closure13(unitVar: (), v0_1: string) -> bool {
            Documents::method28(v0_1)
        }
        pub fn method29(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v105: std::path::PathBuf = std::path::PathBuf::from(v48);
            if v105.clone().exists() {
                v105.is_dir()
            } else {
                false
            }
        }
        pub fn closure14(unitVar: (), v0_1: string) -> bool {
            Documents::method29(v0_1)
        }
        pub fn method31(v0_1: string) -> Option<string> {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v84: std::path::PathBuf = std::path::PathBuf::from(v48);
            let v115: Option<std::path::PathBuf> = v84.parent().map(std::path::PathBuf::from);
            let v117: bool = true;
            let _optionm_map_ = v115.map(|x| {
                //;
                let v119: std::path::PathBuf = x;
                let v126: std::path::Display = v119.display();
                let v162: std::string::String = format!("{}", v126);
                let v193: string = fable_library_rust::String_::fromString(v162);
                let v195: bool = true;
                v193
            });
            _optionm_map_
        }
        pub fn method32(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
            v4: string,
        ) -> Documents::US9 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<bool> = MutCell::new(v2);
            let v3 = MutCell::new(v3.clone());
            let v4: MutCell<string> = MutCell::new(v4.clone());
            '_method32: loop {
                break '_method32 (if v3(Documents::method26(v4.get().clone(), v0_1.get().clone())) {
                    Documents::US9::US9_0(v4.get().clone())
                } else {
                    let v8: Option<string> = Documents::method31(v4.get().clone());
                    let v33: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v8));
                    match &v33 {
                        Documents::US5::US5_0(v33_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: bool = v2.get().clone();
                            let v3_temp = v3.get().clone();
                            let v4_temp: string = match &v33 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method32;
                        }
                        _ => Documents::US9::US9_1(append(
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
        pub fn method30(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
        ) -> Documents::US9 {
            if v3(Documents::method26(v1_1.clone(), v0_1.clone())) {
                Documents::US9::US9_0(v1_1.clone())
            } else {
                let v7: Option<string> = Documents::method31(v1_1.clone());
                let v32: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v32 {
                    Documents::US5::US5_0(v32_0_0) => Documents::method32(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2,
                        v3.clone(),
                        match &v32 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => Documents::US9::US9_1(append(
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
        pub fn method27(v0_1: Documents::US8, v1_1: string, v2: string) -> Documents::US9 {
            let v3: bool = if let Documents::US8::US8_0 = &v0_1 {
                true
            } else {
                false
            };
            Documents::method30(
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
        pub fn method33() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v27: &str = inline_colorization::color_yellow;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method35(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("dir"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v91: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v127: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v144: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method34(
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
            let v10: string = Documents::method35(v8, v9);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.get_workspace_root"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure15(v0_1: string, v1_1: string, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v59,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method34(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method33(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method40(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: std::string::String = format!("{:#?}", v0_1);
            let v56: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v9), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method40(v0_1)
        }
        pub fn method39() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure16((), v))
        }
        pub fn closure17(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method41() -> Func1<std::path::PathBuf, Documents::US10> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: string) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn method42() -> Func1<string, Documents::US10> {
            Func1::new(move |v: string| Documents::closure18((), v))
        }
        pub fn method45(v0_1: string) -> string {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v84: std::path::PathBuf = std::path::PathBuf::from(v48);
            let v115: Option<&std::ffi::OsStr> = v84.file_name();
            let v117: bool = true;
            let _optionm_map_ = v115.map(|x| {
                //;
                let v119: &std::ffi::OsStr = x;
                let v121: std::ffi::OsString = v119.to_os_string();
                let v123: Option<&str> = v121.to_str();
                let v125: &str = v123.unwrap();
                let v132: std::string::String = String::from(v125);
                let v163: string = fable_library_rust::String_::fromString(v132);
                let v165: bool = true;
                v163
            });
            let v167: Option<string> = _optionm_map_;
            let v192: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v167));
            match &v192 {
                Documents::US5::US5_0(v192_0_0) => match &v192 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method46(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v14: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method44(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method45(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v35: string = Documents::method46(v3);
            if (v2) >= 11_u8 {
                let v39: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v46: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v39);
                Err(v46)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v100: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v101 = Documents::method39();
                        let v114: Result<std::path::PathBuf, string> = v100.map_err(|x| v101(x));
                        let v117 = Documents::method41();
                        let v118 = Documents::method42();
                        let v120: Documents::US10 = match &v114 {
                            Err(v114_1_0) => v118(v114_1_0.clone()),
                            Ok(v114_0_0) => v117(v114_0_0.clone()),
                        };
                        match &v120 {
                            Documents::US10::US10_0(v120_0_0) => {
                                let v164: string = Documents::method26(
                                    toString(v120_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v171: &str = &*v164;
                                let v207: std::string::String = String::from(v171);
                                let v243: std::path::PathBuf = std::path::PathBuf::from(v207);
                                Ok(v243)
                            }
                            Documents::US10::US10_1(v120_1_0) => {
                                let v291: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v120_1_0.clone(),
                                        v35.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v298: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v291);
                                Err(v298)
                            }
                        }
                    } else {
                        let v347: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v35.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v354: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v347);
                        Err(v354)
                    }
                } else {
                    let v402: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v35.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v409: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v402);
                    Err(v409)
                }
            }
        }
        pub fn method43(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v9: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v10 = Documents::method39();
            let v23: Result<std::path::PathBuf, string> = v9.map_err(|x| v10(x));
            let v26 = Documents::method41();
            let v27 = Documents::method42();
            let v29: Documents::US10 = match &v23 {
                Err(v23_1_0) => v27(v23_1_0.clone()),
                Ok(v23_0_0) => v26(v23_0_0.clone()),
            };
            match &v29 {
                Documents::US10::US10_0(v29_0_0) => Ok(v29_0_0.clone()),
                Documents::US10::US10_1(v29_1_0) => Documents::method44(
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
                    v29_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure20(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method43(v0_1, v1_1, v2)
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
        pub fn method47(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method45(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v34: string = Documents::method46(v3);
            if (v2) >= 11_u8 {
                let v38: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v45: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v38);
                Err(v45)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v99: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v100 = Documents::method39();
                        let v113: Result<std::path::PathBuf, string> = v99.map_err(|x| v100(x));
                        let v116 = Documents::method41();
                        let v117 = Documents::method42();
                        let v119: Documents::US10 = match &v113 {
                            Err(v113_1_0) => v117(v113_1_0.clone()),
                            Ok(v113_0_0) => v116(v113_0_0.clone()),
                        };
                        match &v119 {
                            Documents::US10::US10_0(v119_0_0) => {
                                let v163: string = Documents::method26(
                                    toString(v119_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v170: &str = &*v163;
                                let v206: std::string::String = String::from(v170);
                                let v242: std::path::PathBuf = std::path::PathBuf::from(v206);
                                Ok(v242)
                            }
                            Documents::US10::US10_1(v119_1_0) => {
                                let v290: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v119_1_0.clone(),
                                        v34.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v297: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v290);
                                Err(v297)
                            }
                        }
                    } else {
                        let v346: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v34.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v353: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v346);
                        Err(v353)
                    }
                } else {
                    let v401: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v34.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v408: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v401);
                    Err(v408)
                }
            }
        }
        pub fn method38(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v8: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v9 = Documents::method39();
            let v22: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
            let v25 = Documents::method41();
            let v26 = Documents::method42();
            let v28: Documents::US10 = match &v22 {
                Err(v22_1_0) => v26(v22_1_0.clone()),
                Ok(v22_0_0) => v25(v22_0_0.clone()),
            };
            match &v28 {
                Documents::US10::US10_0(v28_0_0) => Ok(v28_0_0.clone()),
                Documents::US10::US10_1(v28_1_0) => Documents::method47(
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
                ),
            }
        }
        pub fn method49(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method50() -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method51(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method53(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method45(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v35: string = Documents::method40(v3);
            if (v2) >= 11_u8 {
                let v39: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v46: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v39);
                Err(v46)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v100: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v101 = Documents::method39();
                        let v114: Result<std::path::PathBuf, string> = v100.map_err(|x| v101(x));
                        let v117 = Documents::method41();
                        let v118 = Documents::method42();
                        let v120: Documents::US10 = match &v114 {
                            Err(v114_1_0) => v118(v114_1_0.clone()),
                            Ok(v114_0_0) => v117(v114_0_0.clone()),
                        };
                        match &v120 {
                            Documents::US10::US10_0(v120_0_0) => {
                                let v164: string = Documents::method26(
                                    toString(v120_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v171: &str = &*v164;
                                let v207: std::string::String = String::from(v171);
                                let v243: std::path::PathBuf = std::path::PathBuf::from(v207);
                                Ok(v243)
                            }
                            Documents::US10::US10_1(v120_1_0) => {
                                let v291: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v120_1_0.clone(),
                                        v35.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v298: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v291);
                                Err(v298)
                            }
                        }
                    } else {
                        let v347: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v35.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v354: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v347);
                        Err(v354)
                    }
                } else {
                    let v402: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v35.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v409: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v402);
                    Err(v409)
                }
            }
        }
        pub fn method52(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v45: i32 =
                Documents::method49(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v47: bool = Documents::method51(Documents::method50(), v45);
            if v47 {
                let v54: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v131: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v131)
            } else {
                let v153: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v47,
                        v2.clone(),
                        v1_1
                    ),
                );
                Documents::method53(
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
                    std::io::Error::new(std::io::ErrorKind::Other, &*v153),
                    v2,
                )
            }
        }
        pub fn closure22(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method52(v0_1, v1_1, v2)
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
        pub fn method54(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method45(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v34: string = Documents::method40(v3);
            if (v2) >= 11_u8 {
                let v38: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v45: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v38);
                Err(v45)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v99: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v100 = Documents::method39();
                        let v113: Result<std::path::PathBuf, string> = v99.map_err(|x| v100(x));
                        let v116 = Documents::method41();
                        let v117 = Documents::method42();
                        let v119: Documents::US10 = match &v113 {
                            Err(v113_1_0) => v117(v113_1_0.clone()),
                            Ok(v113_0_0) => v116(v113_0_0.clone()),
                        };
                        match &v119 {
                            Documents::US10::US10_0(v119_0_0) => {
                                let v163: string = Documents::method26(
                                    toString(v119_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v170: &str = &*v163;
                                let v206: std::string::String = String::from(v170);
                                let v242: std::path::PathBuf = std::path::PathBuf::from(v206);
                                Ok(v242)
                            }
                            Documents::US10::US10_1(v119_1_0) => {
                                let v290: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v119_1_0.clone(),
                                        v34.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v297: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v290);
                                Err(v297)
                            }
                        }
                    } else {
                        let v346: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v34.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v353: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v346);
                        Err(v353)
                    }
                } else {
                    let v401: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v34.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v408: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v401);
                    Err(v408)
                }
            }
        }
        pub fn method48(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v44: i32 =
                Documents::method49(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v46: bool = Documents::method51(Documents::method50(), v44);
            if v46 {
                let v53: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v130: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v130)
            } else {
                let v152: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v46,
                        v0_1.clone(),
                        v1_1
                    ),
                );
                Documents::method54(
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
                    std::io::Error::new(std::io::ErrorKind::Other, &*v152),
                )
            }
        }
        pub fn method37(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method29(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method38(v0_1, 0_u8)
            }
        }
        pub fn closure23(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn method55() -> Func1<std::path::PathBuf, Documents::US11> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure23((), v))
        }
        pub fn method57(v0_1: string) -> string {
            v0_1
        }
        pub fn method58() -> string {
            string("")
        }
        pub fn method56(v0_1: string, v1_1: string, v2: string) -> string {
            let v6: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v10: regex::Regex = v6.unwrap();
            let v22: string = Documents::method57(v2);
            let v24: std::borrow::Cow<str> = v10.replace_all(&*v22, &*v1_1);
            let v26: std::string::String = String::from(v24);
            fable_library_rust::String_::fromString(v26)
        }
        pub fn method36(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method37(v0_1.clone());
                let v7: Option<std::path::PathBuf> = v3.ok();
                let v43: Documents::US11 =
                    defaultValue(Documents::US11::US11_1, map(Documents::method55(), v7));
                let v89: string = match &v43 {
                    Documents::US11::US11_0(v43_0_0) => toString(
                        match &v43 {
                            Documents::US11::US11_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone()
                        .display(),
                    ),
                    _ => v0_1.clone(),
                };
                let v94: string = Documents::method56(
                    string("^\\\\\\\\\\?\\\\"),
                    string(""),
                    if (v89.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v89
                    },
                );
                if (length(v94.clone())) < 2_i32 {
                    v0_1.clone()
                } else {
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v94.clone(), 0_i32))),
                            getSlice(v94, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method25(v0_1: string) -> Documents::US5 {
            let v5: Documents::US9 = Documents::method27(
                Documents::US8::US8_1,
                Documents::method26(string("spiral"), string("workspace")),
                v0_1.clone(),
            );
            match &v5 {
                Documents::US9::US9_0(v5_0_0) => {
                    Documents::US5::US5_0(Documents::method36(v5_0_0.clone()))
                }
                Documents::US9::US9_1(v5_1_0) => {
                    let v323: () = {
                        Documents::closure15(v0_1.clone(), v5_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            }
        }
        pub fn method60(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method61(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method62() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method63(v0_1: string) -> string {
            v0_1
        }
        pub fn method59(v0_1: string) -> string {
            let v12: &str = &*v0_1.clone();
            let v48: std::string::String = String::from(v12);
            let v84: std::path::PathBuf = std::path::PathBuf::from(v48);
            if (v84.exists()) == false {
                let v117: string = Documents::method24();
                let v131: Array<string> = split(
                    Documents::method36(Documents::method26(v117.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v135: i32 = get_Count(v131.clone());
                let v136: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method60(v135, v136.clone()) {
                    let v138: i32 = v136.l0.get().clone();
                    let v141: i32 = ((v138.wrapping_neg()) + (v135)) - 1_i32;
                    let matchValue: i32 = v136.l1.get().clone();
                    let v143: Array<string> = v136.l2.get().clone();
                    let v142: i32 = matchValue;
                    let v144: string = v131[v141].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v144.clone()) {
                        ((v142) + 1_i32, v143.clone())
                    } else {
                        if string(".") == (v144.clone()) {
                            (v142, v143.clone())
                        } else {
                            if 0_i32 == (v142) {
                                if endsWith3(v144.clone(), string(":"), false) {
                                    let v156: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v117.clone(), 0_i32)
                                    )]);
                                    let v157: i32 = get_Count(v156.clone());
                                    let v159: i32 = (v157) + (get_Count(v143.clone()));
                                    let v160: Array<string> = new_init(&string(""), v159);
                                    let v161: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method61(v159, v161.clone()) {
                                        let v163: i32 = v161.l0.get().clone();
                                        let v168: string = if (v163) < (v157) {
                                            v156[v163].clone()
                                        } else {
                                            let v166: i32 = (v163) - (v157);
                                            v143[v166].clone()
                                        };
                                        v160.get_mut()[v163 as usize] = v168;
                                        {
                                            let v169: i32 = (v163) + 1_i32;
                                            v161.l0.set(v169);
                                            ()
                                        }
                                    }
                                    (0_i32, v160.clone())
                                } else {
                                    let v170: Array<string> = new_array(&[v144]);
                                    let v171: i32 = get_Count(v170.clone());
                                    let v173: i32 = (v171) + (get_Count(v143.clone()));
                                    let v174: Array<string> = new_init(&string(""), v173);
                                    let v175: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method61(v173, v175.clone()) {
                                        let v177: i32 = v175.l0.get().clone();
                                        let v182: string = if (v177) < (v171) {
                                            v170[v177].clone()
                                        } else {
                                            let v180: i32 = (v177) - (v171);
                                            v143[v180].clone()
                                        };
                                        v174.get_mut()[v177 as usize] = v182;
                                        {
                                            let v183: i32 = (v177) + 1_i32;
                                            v175.l0.set(v183);
                                            ()
                                        }
                                    }
                                    (0_i32, v174.clone())
                                }
                            } else {
                                ((v142) - 1_i32, v143.clone())
                            }
                        }
                    };
                    let v193: i32 = (v138) + 1_i32;
                    v136.l0.set(v193);
                    v136.l1.set(patternInput_1.0.clone());
                    v136.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v136.l1.get().clone();
                    let v195: Array<string> = v136.l2.get().clone();
                    let _let__v200: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v195 = v195.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v195 = v195.clone();
                                    move |i: i32| v195[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v195.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v212: string = ofChar(Documents::method62());
                    join(
                        if (v212.clone()) == string("\n") {
                            Documents::method63(v212.clone())
                        } else {
                            v212
                        },
                        toArray_1(_let__v200),
                    )
                }
            } else {
                let v225: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v229: std::path::PathBuf = v225.unwrap();
                let v247: std::path::Display = v229.display();
                let v283: std::string::String = format!("{}", v247);
                fable_library_rust::String_::fromString(v283)
            }
        }
        pub fn method64() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v27: &str = inline_colorization::color_bright_blue;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method66(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v19: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v5.clone(), string("source_dir"), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v5.clone(), v0_1, ());
                ()
            };
            let v93: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v5.clone(), string("dist_dir"), ());
                ()
            };
            let v129: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v146: () = {
                Documents::closure8(v5.clone(), v1_1, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v182: () = {
                Documents::closure8(v5.clone(), string("cache_dir"), ());
                ()
            };
            let v199: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v216: () = {
                Documents::closure8(v5.clone(), v2, ());
                ()
            };
            let v233: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v252: () = {
                Documents::closure8(v5.clone(), string("hangul_spec"), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v286: () = {
                Documents::closure8(v5.clone(), v3, ());
                ()
            };
            let v305: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method65(
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
            let v12: string = Documents::method66(v8, v9, v10, v11);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run"),
                    )),
                    string(" / "),
                )),
                (v12),
            ))
        }
        pub fn closure24(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            fn v19() {
                Documents::closure6((), ());
            }
            let v20: () = {
                v19();
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
            let v61: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v84: () = {
                    v19();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v112: Option<i64> = patternInput_1.5.clone();
                let v111: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v110: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v109: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v108: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v107: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = Documents::method65(
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    v112.clone(),
                    Documents::method7(v107, v108, v109, v110, v111, v112),
                    Documents::method64(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                );
                let v143: () = {
                    v19();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure26(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method67() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: std::fs::FileType) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn method68() -> Func1<std::fs::FileType, Documents::US12> {
            Func1::new(move |v: std::fs::FileType| Documents::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn method69() -> Func1<std::string::String, Documents::US12> {
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
                            let v19 = Documents::method67();
                            let v32: Result<std::fs::FileType, std::string::String> =
                                v18.map_err(|x| v19(x));
                            let v35 = Documents::method68();
                            let v36 = Documents::method69();
                            let v38: Documents::US12 = match &v32 {
                                Err(v32_1_0) => v36(v32_1_0.clone()),
                                Ok(v32_0_0) => v35(v32_0_0.clone()),
                            };
                            let v232: Documents::US13 = if let Documents::US12::US12_0(v38_0_0) =
                                &v38
                            {
                                if std::fs::FileType::is_dir(&v38_0_0.clone()) {
                                    Documents::US13::US13_0
                                } else {
                                    let v46: std::path::PathBuf =
                                        async_walkdir::DirEntry::path(&v0_1.clone());
                                    let v53: std::path::Display = v46.display();
                                    let v89: std::string::String = format!("{}", v53);
                                    let v120: string = fable_library_rust::String_::fromString(v89);
                                    if if (endsWith3(v120.clone(), string(".md"), false)) == false {
                                        true
                                    } else {
                                        endsWith3(v120, string(".hangul.md"), false)
                                    } {
                                        Documents::US13::US13_0
                                    } else {
                                        Documents::US13::US13_2
                                    }
                                }
                            } else {
                                let v140: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                                let v147: std::path::Display = v140.display();
                                let v183: std::string::String = format!("{}", v147);
                                let v214: string = fable_library_rust::String_::fromString(v183);
                                if if (endsWith3(v214.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    endsWith3(v214, string(".hangul.md"), false)
                                } {
                                    Documents::US13::US13_0
                                } else {
                                    Documents::US13::US13_2
                                }
                            };
                            let v235: string = string("}");
                            let v240: bool = true;
                            let _fix_closure_v237 = v232;
                            let v246: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v237 "), (v235))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v247: bool = true;
                            _fix_closure_v237
                        },
                    ); // rust.fix_closure';
                    let v249 = __future_init;
                    let v251: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US13> + Send>,
                    > = v249;
                    let v253: Documents::US13 = v251.await;
                    let v262: async_walkdir::Filtering = match &v253 {
                        Documents::US13::US13_0 => async_walkdir::Filtering::Ignore,
                        Documents::US13::US13_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v263: string = string("}");
                    let v268: bool = true;
                    let _fix_closure_v265 = v262;
                    let v274: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v265 "), (v263))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v275: bool = true;
                    _fix_closure_v265
                },
            ); // rust.fix_closure';
            let v277 = __future_init;
            v277
        }
        pub fn closure30(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method71() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US14 {
            Documents::US14::US14_0(v0_1)
        }
        pub fn method72() -> Func1<async_walkdir::DirEntry, Documents::US14> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US14 {
            Documents::US14::US14_1(v0_1)
        }
        pub fn method73() -> Func1<std::string::String, Documents::US14> {
            Func1::new(move |v: std::string::String| Documents::closure32((), v))
        }
        pub fn method74() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Critical")), 0_i32));
            let v27: &str = inline_colorization::color_bright_red;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method76(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("error"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method75(
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
            let v9: string = Documents::method76(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run / stream_filter_map"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure33(v0_1: std::string::String, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method75(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method74(),
                    v0_1,
                );
                let v140: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure29(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method71();
            let v14: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17 = Documents::method72();
            let v18 = Documents::method73();
            let v20: Documents::US14 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v732: Documents::US5 = match &v20 {
                Documents::US14::US14_0(v20_0_0) => {
                    let v25: std::path::PathBuf = async_walkdir::DirEntry::path(&v20_0_0.clone());
                    let v32: std::path::Display = v25.display();
                    let v68: std::string::String = format!("{}", v32);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v68))
                }
                Documents::US14::US14_1(v20_1_0) => {
                    let v415: () = {
                        Documents::closure33(v20_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v732 {
                Documents::US5::US5_0(v732_0_0) => Some(
                    match &v732 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method70()
        -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure29((), v)
                },
            )
        }
        pub fn method78(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("files_len"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
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
            v8: usize,
        ) -> string {
            let v9: string = Documents::method78(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure34(v0_1: Vec<string>, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method77(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method64(),
                    v0_1.len(),
                );
                let v142: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method79() -> string {
            string("")
        }
        pub fn method80(v0_1: string) -> string {
            Documents::method36(Documents::method59(v0_1))
        }
        pub fn method82(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> string {
            v0_1
        }
        pub fn method84() -> string {
            string("")
        }
        pub fn method85(v0_1: char, v1_1: LrcPtr<StringBuilder>, v2: i32, v3: i32) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v19: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v5.clone(), string("c"), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v77: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v115: () = {
                Documents::closure8(v5.clone(), string("s"), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v144: std::string::String = format!("{:#?}", v1_1);
            let v191: () = {
                Documents::closure8(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v144),
                    (),
                );
                ()
            };
            let v210: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method86(v0_1: i64, v1_1: string, v2: i64) -> LrcPtr<Documents::UH0> {
            if (v2) < (v0_1) {
                LrcPtr::new(Documents::UH0::UH0_1(
                    getCharAt(v1_1.clone(), v2 as i32),
                    Documents::method86(v0_1, v1_1, (v2) + 1_i64),
                ))
            } else {
                LrcPtr::new(Documents::UH0::UH0_0)
            }
        }
        pub fn method87(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method87: loop {
                break '_method87 (match v0_1.get().clone().as_ref() {
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
                                let v12: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v23: LrcPtr<StringBuilder> = {
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
                            continue '_method87;
                        }
                    }
                });
            }
        }
        pub fn method88(v0_1: char, v1_1: i32, v2: i32) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("expected"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v4.clone(), string("line"), ());
                ()
            };
            let v131: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Documents::closure8(v4.clone(), string("col"), ());
                ()
            };
            let v204: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v243: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn closure37(v0_1: i32, v1_1: i32, v2: string) -> string {
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
                move |v: string| Documents::closure37(v0_1, v1_1, v)
            })
        }
        pub fn closure36(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(append(
                    string("parsing.p_char / unexpected end of input / "),
                    (Documents::method85('\"', v1_1.clone(), v2, v3)),
                ))
            } else {
                let v14: char = getCharAt(v0_1.clone(), 0_i32);
                if (v14) == '\"' {
                    let v51: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v57: string = ofChar(v14);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                        Documents::method86(length(v57.clone()) as i64, v57, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v14,
                        v51,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v74: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    let v114: string = getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(
                            (if -2_i32 == (v74) {
                                (length(v0_1)) + 1_i32
                            } else {
                                (v74) + 1_i32
                            }) - 1_i32,
                        ),
                    );
                    Documents::US16::US16_1(append(
                        (append(
                            (append(
                                (append(
                                    (append(
                                        (append(
                                            (append(
                                                string("parsing.p_char / "),
                                                (Documents::method88('\"', v2, v3)),
                                            )),
                                            string("\n"),
                                        )),
                                        (toString(v1_1)),
                                    )),
                                    (v114),
                                )),
                                string("\n"),
                            )),
                            (append(
                                ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                                string("^"),
                            )),
                        )),
                        string("\n"),
                    ))
                }
            }
        }
        pub fn closure38(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(append(
                    string("parsing.p_char / unexpected end of input / "),
                    (Documents::method85('\'', v1_1.clone(), v2, v3)),
                ))
            } else {
                let v14: char = getCharAt(v0_1.clone(), 0_i32);
                if (v14) == '\'' {
                    let v51: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v57: string = ofChar(v14);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                        Documents::method86(length(v57.clone()) as i64, v57, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v14,
                        v51,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v74: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    let v114: string = getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(
                            (if -2_i32 == (v74) {
                                (length(v0_1)) + 1_i32
                            } else {
                                (v74) + 1_i32
                            }) - 1_i32,
                        ),
                    );
                    Documents::US16::US16_1(append(
                        (append(
                            (append(
                                (append(
                                    (append(
                                        (append(
                                            (append(
                                                string("parsing.p_char / "),
                                                (Documents::method88('\'', v2, v3)),
                                            )),
                                            string("\n"),
                                        )),
                                        (toString(v1_1)),
                                    )),
                                    (v114),
                                )),
                                string("\n"),
                            )),
                            (append(
                                ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                                string("^"),
                            )),
                        )),
                        string("\n"),
                    ))
                }
            }
        }
        pub fn method90(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method90: loop {
                break '_method90 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US16::US16_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US16 = (match v2.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Documents::US16::US16_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => {
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
        pub fn method91(v0_1: Array<char>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v19: () = {
                Documents::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method92(v0_1: string, v1_1: LrcPtr<StringBuilder>, v2: i32, v3: i32) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v19: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v5.clone(), string("chars"), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v5.clone(), v0_1, ());
                ()
            };
            let v93: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v5.clone(), string("s"), ());
                ()
            };
            let v129: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v141: std::string::String = format!("{:#?}", v1_1);
            let v188: () = {
                Documents::closure8(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v141),
                    (),
                );
                ()
            };
            let v207: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method93(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method93: loop {
                break '_method93 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US18::US18_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US18::US18_0(v11_0_0) => match &v11 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method93;
                    }
                });
            }
        }
        pub fn method94(
            v0_1: char,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> string {
            let v6: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v20: () = {
                Documents::closure8(v6.clone(), string("{ "), ());
                ()
            };
            let v39: () = {
                Documents::closure8(v6.clone(), string("first_char"), ());
                ()
            };
            let v58: () = {
                Documents::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v78: () = {
                Documents::closure8(v6.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v97: () = {
                Documents::closure8(v6.clone(), string("; "), ());
                ()
            };
            let v116: () = {
                Documents::closure8(v6.clone(), string("chars"), ());
                ()
            };
            let v133: () = {
                Documents::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v6.clone(), v1_1, ());
                ()
            };
            let v167: () = {
                Documents::closure8(v6.clone(), string("; "), ());
                ()
            };
            let v186: () = {
                Documents::closure8(v6.clone(), string("s"), ());
                ()
            };
            let v203: () = {
                Documents::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v215: std::string::String = format!("{:#?}", v2);
            let v262: () = {
                Documents::closure8(
                    v6.clone(),
                    fable_library_rust::String_::fromString(v215),
                    (),
                );
                ()
            };
            let v281: () = {
                Documents::closure8(v6.clone(), string(" }"), ());
                ()
            };
            v6.l0.get().clone()
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
                    let v176: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.none_of / unexpected end of input / "),
                            (Documents::method92(
                                Documents::method91(toArray(ofArray(new_array(&['\"', '\''])))),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v63: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method93(v63, 0_i64)) == false {
                            let v102: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v108: string = ofChar(v63);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    Documents::method86(length(v108.clone()) as i64, v108, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v63,
                                v102,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected char / "),
                                (Documents::method94(
                                    v63,
                                    Documents::method91(toArray(ofArray(new_array(&['\"', '\''])))),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                )),
                            ))
                        }
                    };
                    let v188: Documents::US16 = match &v176 {
                        Documents::US16::US16_0(
                            v176_0_0,
                            v176_0_1,
                            v176_0_2,
                            v176_0_3,
                            v176_0_4,
                        ) => {
                            let v177: char = v176_0_0.clone();
                            Documents::US16::US16_0(
                                if '\\' == (v177) { '/' } else { v177 },
                                v176_0_1.clone(),
                                v176_0_2.clone(),
                                v176_0_3.clone(),
                                v176_0_4.clone(),
                            )
                        }
                        Documents::US16::US16_1(v176_1_0) => {
                            Documents::US16::US16_1(v176_1_0.clone())
                        }
                    };
                    match &v188 {
                        Documents::US16::US16_0(
                            v188_0_0,
                            v188_0_1,
                            v188_0_2,
                            v188_0_3,
                            v188_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v188_0_0.clone())));
                            let v1_1_temp: string = v188_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v188_0_2.clone();
                            let v3_temp: i32 = v188_0_3.clone();
                            let v4_temp: i32 = v188_0_4.clone();
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
        pub fn method96(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH1>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v4.clone());
            '_method96: loop {
                break '_method96 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US16::US16_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US16 = (match v4.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
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
                                continue '_method96;
                            }
                        }
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
            v5: string,
            v6: LrcPtr<StringBuilder>,
            v7: i32,
            v8: i32,
            v9: string,
            v10: LrcPtr<StringBuilder>,
            v11: i32,
            v12: i32,
        ) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v28: () = {
                Documents::closure8(v14.clone(), string("{ "), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v14.clone(), string("e"), ());
                ()
            };
            let v66: () = {
                Documents::closure8(v14.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v14.clone(), v0_1, ());
                ()
            };
            let v102: () = {
                Documents::closure8(v14.clone(), string("; "), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v14.clone(), string("input"), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v14.clone(), string(" = "), ());
                ()
            };
            let v155: () = {
                Documents::closure8(v14.clone(), v1_1, ());
                ()
            };
            let v174: () = {
                Documents::closure8(v14.clone(), string(", "), ());
                ()
            };
            let v186: std::string::String = format!("{:#?}", v2);
            let v233: () = {
                Documents::closure8(
                    v14.clone(),
                    fable_library_rust::String_::fromString(v186),
                    (),
                );
                ()
            };
            let v250: () = {
                Documents::closure8(v14.clone(), string("; "), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v14.clone(), string("rest1"), ());
                ()
            };
            let v286: () = {
                Documents::closure8(v14.clone(), string(" = "), ());
                ()
            };
            let v303: () = {
                Documents::closure8(v14.clone(), v5, ());
                ()
            };
            let v320: () = {
                Documents::closure8(v14.clone(), string(", "), ());
                ()
            };
            let v332: std::string::String = format!("{:#?}", v6);
            let v379: () = {
                Documents::closure8(
                    v14.clone(),
                    fable_library_rust::String_::fromString(v332),
                    (),
                );
                ()
            };
            let v396: () = {
                Documents::closure8(v14.clone(), string("; "), ());
                ()
            };
            let v415: () = {
                Documents::closure8(v14.clone(), string("rest2"), ());
                ()
            };
            let v432: () = {
                Documents::closure8(v14.clone(), string(" = "), ());
                ()
            };
            let v449: () = {
                Documents::closure8(v14.clone(), v9, ());
                ()
            };
            let v466: () = {
                Documents::closure8(v14.clone(), string(", "), ());
                ()
            };
            let v478: std::string::String = format!("{:#?}", v10);
            let v525: () = {
                Documents::closure8(
                    v14.clone(),
                    fable_library_rust::String_::fromString(v478),
                    (),
                );
                ()
            };
            let v544: () = {
                Documents::closure8(v14.clone(), string(" }"), ());
                ()
            };
            v14.l0.get().clone()
        }
        pub fn method98(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method98: loop {
                break '_method98 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US18::US18_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US18::US18_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US18::US18_0(v15_0_0) => match &v15 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method98;
                    }
                });
            }
        }
        pub fn method99(
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
            '_method99: loop {
                break '_method99 ({
                    let v200: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.none_of / unexpected end of input / "),
                            (Documents::method92(
                                Documents::method91(toArray(ofArray(new_array(&[
                                    '\"', '\'', ' ',
                                ])))),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v75: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method98(v75, 0_i64)) == false {
                            let v114: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v120: string = ofChar(v75);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    Documents::method86(length(v120.clone()) as i64, v120, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v75,
                                v114,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected char / "),
                                (Documents::method94(
                                    v75,
                                    Documents::method91(toArray(ofArray(new_array(&[
                                        '\"', '\'', ' ',
                                    ])))),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                )),
                            ))
                        }
                    };
                    let v212: Documents::US16 = match &v200 {
                        Documents::US16::US16_0(
                            v200_0_0,
                            v200_0_1,
                            v200_0_2,
                            v200_0_3,
                            v200_0_4,
                        ) => {
                            let v201: char = v200_0_0.clone();
                            Documents::US16::US16_0(
                                if '\\' == (v201) { '/' } else { v201 },
                                v200_0_1.clone(),
                                v200_0_2.clone(),
                                v200_0_3.clone(),
                                v200_0_4.clone(),
                            )
                        }
                        Documents::US16::US16_1(v200_1_0) => {
                            Documents::US16::US16_1(v200_1_0.clone())
                        }
                    };
                    match &v212 {
                        Documents::US16::US16_0(
                            v212_0_0,
                            v212_0_1,
                            v212_0_2,
                            v212_0_3,
                            v212_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v212_0_0.clone())));
                            let v1_1_temp: string = v212_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v212_0_2.clone();
                            let v3_temp: i32 = v212_0_3.clone();
                            let v4_temp: i32 = v212_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method99;
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
        pub fn method100(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("input"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            let v90: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method101(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method101: loop {
                break '_method101 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method101;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method102(v0_1: LrcPtr<StringBuilder>, v1_1: i32, v2: i32) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("s"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v68: std::string::String = format!("{:#?}", v0_1);
            let v115: () = {
                Documents::closure8(v4.clone(), fable_library_rust::String_::fromString(v68), ());
                ()
            };
            let v134: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method103(
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
            '_method103: loop {
                break '_method103 ({
                    let v66: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.any_char / unexpected end of input / "),
                            (Documents::method102(
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v56: string = ofChar(v14);
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            Documents::method86(length(v56.clone()) as i64, v56, 0_i64),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        );
                        Documents::US16::US16_0(
                            v14,
                            v50,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    };
                    match &v66 {
                        Documents::US16::US16_0(v66_0_0, v66_0_1, v66_0_2, v66_0_3, v66_0_4) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v66_0_0.clone())));
                            let v1_1_temp: string = v66_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v66_0_2.clone();
                            let v3_temp: i32 = v66_0_3.clone();
                            let v4_temp: i32 = v66_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method103;
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
        pub fn method83(v0_1: string) -> Documents::US15 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v10: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v16: LrcPtr<StringBuilder> =
                    StringBuilder::_ctor__Z721C83C5(Documents::method84());
                fn v19(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US16 {
                    Documents::closure36((), arg10_0040)
                }
                fn v20(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US16 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v24: Documents::US16 = Documents::method90(
                    v10.clone(),
                    v16.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v19),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v20),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v280: Documents::US17 = match &v24 {
                    Documents::US16::US16_0(v24_0_0, v24_0_1, v24_0_2, v24_0_3, v24_0_4) => {
                        let v29: i32 = v24_0_4.clone();
                        let v28: i32 = v24_0_3.clone();
                        let v27: LrcPtr<StringBuilder> = v24_0_2.clone();
                        let v26: string = v24_0_1.clone();
                        let v201: Documents::US16 = if string("") == (v26.clone()) {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected end of input / "),
                                (Documents::method92(
                                    Documents::method91(toArray(ofArray(new_array(&['\"', '\''])))),
                                    v27.clone(),
                                    v28,
                                    v29,
                                )),
                            ))
                        } else {
                            let v88: char = getCharAt(v26.clone(), 0_i32);
                            if (Documents::method93(v88, 0_i64)) == false {
                                let v127: string = getSlice(
                                    v26.clone(),
                                    Some(1_i32),
                                    Some((length(v26.clone())) - 1_i32),
                                );
                                let v133: string = ofChar(v88);
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method87(
                                        Documents::method86(
                                            length(v133.clone()) as i64,
                                            v133,
                                            0_i64,
                                        ),
                                        v27.clone(),
                                        v28,
                                        v29,
                                    );
                                Documents::US16::US16_0(
                                    v88,
                                    v127,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            } else {
                                Documents::US16::US16_1(append(
                                    string("parsing.none_of / unexpected char / "),
                                    (Documents::method94(
                                        v88,
                                        Documents::method91(toArray(ofArray(new_array(&[
                                            '\"', '\'',
                                        ])))),
                                        v27.clone(),
                                        v28,
                                        v29,
                                    )),
                                ))
                            }
                        };
                        let v213: Documents::US16 = match &v201 {
                            Documents::US16::US16_0(
                                v201_0_0,
                                v201_0_1,
                                v201_0_2,
                                v201_0_3,
                                v201_0_4,
                            ) => {
                                let v202: char = v201_0_0.clone();
                                Documents::US16::US16_0(
                                    if '\\' == (v202) { '/' } else { v202 },
                                    v201_0_1.clone(),
                                    v201_0_2.clone(),
                                    v201_0_3.clone(),
                                    v201_0_4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v201_1_0) => {
                                Documents::US16::US16_1(v201_1_0.clone())
                            }
                        };
                        let v233: Documents::US17 = match &v213 {
                            Documents::US16::US16_0(
                                v213_0_0,
                                v213_0_1,
                                v213_0_2,
                                v213_0_3,
                                v213_0_4,
                            ) => {
                                let patternInput_1: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method95(
                                    ofChar(v213_0_0.clone()),
                                    v213_0_1.clone(),
                                    v213_0_2.clone(),
                                    v213_0_3.clone(),
                                    v213_0_4.clone(),
                                );
                                Documents::US17::US17_0(
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                    patternInput_1.4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v213_1_0) => {
                                Documents::US17::US17_1(v213_1_0.clone())
                            }
                        };
                        let v243: Documents::US17 = match &v233 {
                            Documents::US17::US17_0(
                                v233_0_0,
                                v233_0_1,
                                v233_0_2,
                                v233_0_3,
                                v233_0_4,
                            ) => Documents::US17::US17_0(
                                v233_0_0.clone(),
                                v233_0_1.clone(),
                                v233_0_2.clone(),
                                v233_0_3.clone(),
                                v233_0_4.clone(),
                            ),
                            _ => Documents::US17::US17_0(
                                string(""),
                                v26.clone(),
                                v27.clone(),
                                v28,
                                v29,
                            ),
                        };
                        match &v243 {
                            Documents::US17::US17_0(
                                v243_0_0,
                                v243_0_1,
                                v243_0_2,
                                v243_0_3,
                                v243_0_4,
                            ) => {
                                let v248: i32 = v243_0_4.clone();
                                let v247: i32 = v243_0_3.clone();
                                let v246: LrcPtr<StringBuilder> = v243_0_2.clone();
                                let v245: string = v243_0_1.clone();
                                let v252: Documents::US16 = Documents::method96(
                                    v245.clone(),
                                    v246.clone(),
                                    v247,
                                    v248,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v19),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v20),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v252 {
                                    Documents::US16::US16_0(
                                        v252_0_0,
                                        v252_0_1,
                                        v252_0_2,
                                        v252_0_3,
                                        v252_0_4,
                                    ) => Documents::US17::US17_0(
                                        v243_0_0.clone(),
                                        v252_0_1.clone(),
                                        v252_0_2.clone(),
                                        v252_0_3.clone(),
                                        v252_0_4.clone(),
                                    ),
                                    Documents::US16::US16_1(v252_1_0) => {
                                        Documents::US17::US17_1(append(
                                            string(
                                                "parsing.between / expected closing delimiter / ",
                                            ),
                                            (Documents::method97(
                                                v252_1_0.clone(),
                                                v10.clone(),
                                                v16.clone(),
                                                1_i32,
                                                1_i32,
                                                v26.clone(),
                                                v27.clone(),
                                                v28,
                                                v29,
                                                v245.clone(),
                                                v246.clone(),
                                                v247,
                                                v248,
                                            )),
                                        ))
                                    }
                                }
                            }
                            _ => Documents::US17::US17_1(string(
                                "parsing.between / expected content",
                            )),
                        }
                    }
                    Documents::US16::US16_1(v24_1_0) => Documents::US17::US17_1(v24_1_0.clone()),
                };
                let v602: Documents::US17 = match &v280 {
                    Documents::US17::US17_0(v280_0_0, v280_0_1, v280_0_2, v280_0_3, v280_0_4) => {
                        v280.clone()
                    }
                    _ => {
                        let v488: Documents::US16 = if string("") == (v10.clone()) {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected end of input / "),
                                (Documents::method92(
                                    Documents::method91(toArray(ofArray(new_array(&[
                                        '\"', '\'', ' ',
                                    ])))),
                                    v16.clone(),
                                    1_i32,
                                    1_i32,
                                )),
                            ))
                        } else {
                            let v359: char = getCharAt(v10.clone(), 0_i32);
                            if (Documents::method98(v359, 0_i64)) == false {
                                let v398: string = getSlice(
                                    v10.clone(),
                                    Some(1_i32),
                                    Some((length(v10.clone())) - 1_i32),
                                );
                                let v404: string = ofChar(v359);
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method87(
                                        Documents::method86(
                                            length(v404.clone()) as i64,
                                            v404,
                                            0_i64,
                                        ),
                                        v16.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Documents::US16::US16_0(
                                    v359,
                                    v398,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            } else {
                                Documents::US16::US16_1(append(
                                    string("parsing.none_of / unexpected char / "),
                                    (Documents::method94(
                                        v359,
                                        Documents::method91(toArray(ofArray(new_array(&[
                                            '\"', '\'', ' ',
                                        ])))),
                                        v16.clone(),
                                        1_i32,
                                        1_i32,
                                    )),
                                ))
                            }
                        };
                        let v500: Documents::US16 = match &v488 {
                            Documents::US16::US16_0(
                                v488_0_0,
                                v488_0_1,
                                v488_0_2,
                                v488_0_3,
                                v488_0_4,
                            ) => {
                                let v489: char = v488_0_0.clone();
                                Documents::US16::US16_0(
                                    if '\\' == (v489) { '/' } else { v489 },
                                    v488_0_1.clone(),
                                    v488_0_2.clone(),
                                    v488_0_3.clone(),
                                    v488_0_4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v488_1_0) => {
                                Documents::US16::US16_1(v488_1_0.clone())
                            }
                        };
                        let v520: Documents::US17 = match &v500 {
                            Documents::US16::US16_0(
                                v500_0_0,
                                v500_0_1,
                                v500_0_2,
                                v500_0_3,
                                v500_0_4,
                            ) => {
                                let patternInput_3: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method99(
                                    ofChar(v500_0_0.clone()),
                                    v500_0_1.clone(),
                                    v500_0_2.clone(),
                                    v500_0_3.clone(),
                                    v500_0_4.clone(),
                                );
                                Documents::US17::US17_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                    patternInput_3.4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v500_1_0) => {
                                Documents::US17::US17_1(v500_1_0.clone())
                            }
                        };
                        match &v520 {
                            Documents::US17::US17_0(
                                v520_0_0,
                                v520_0_1,
                                v520_0_2,
                                v520_0_3,
                                v520_0_4,
                            ) => v520.clone(),
                            _ => {
                                let v538: Documents::US19 = if (length(v10.clone())) == 0_i32 {
                                    Documents::US19::US19_0(v10.clone(), v16.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US19::US19_1(append(
                                        string("parsing.eof / expected end of input / "),
                                        (Documents::method100(v10.clone())),
                                    ))
                                };
                                let v547: Documents::US17 = match &v538 {
                                    Documents::US19::US19_0(
                                        v538_0_0,
                                        v538_0_1,
                                        v538_0_2,
                                        v538_0_3,
                                    ) => Documents::US17::US17_0(
                                        string(""),
                                        v538_0_0.clone(),
                                        v538_0_1.clone(),
                                        v538_0_2.clone(),
                                        v538_0_3.clone(),
                                    ),
                                    Documents::US19::US19_1(v538_1_0) => {
                                        Documents::US17::US17_1(v538_1_0.clone())
                                    }
                                };
                                match &v547 {
                                    Documents::US17::US17_0(
                                        v547_0_0,
                                        v547_0_1,
                                        v547_0_2,
                                        v547_0_3,
                                        v547_0_4,
                                    ) => {
                                        let v549: string = v547_0_1.clone();
                                        Documents::US17::US17_0(
                                            v547_0_0.clone(),
                                            getSlice(
                                                v549.clone(),
                                                Some(Documents::method101(v549.clone(), 0_i32)),
                                                Some((length(v549)) - 1_i32),
                                            ),
                                            v547_0_2.clone(),
                                            v547_0_3.clone(),
                                            v547_0_4.clone(),
                                        )
                                    }
                                    Documents::US17::US17_1(v547_1_0) => {
                                        Documents::US17::US17_1(v547_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v900: Documents::US20 = match &v602 {
                    Documents::US17::US17_0(v602_0_0, v602_0_1, v602_0_2, v602_0_3, v602_0_4) => {
                        let v607: i32 = v602_0_4.clone();
                        let v606: i32 = v602_0_3.clone();
                        let v605: LrcPtr<StringBuilder> = v602_0_2.clone();
                        let v604: string = v602_0_1.clone();
                        let v771: Documents::US16 = if string("") == (v604.clone()) {
                            Documents::US16::US16_1(append(
                                string("parsing.p_char / unexpected end of input / "),
                                (Documents::method85(' ', v605.clone(), v606, v607)),
                            ))
                        } else {
                            let v618: char = getCharAt(v604.clone(), 0_i32);
                            if (v618) == ' ' {
                                let v655: string = getSlice(
                                    v604.clone(),
                                    Some(1_i32),
                                    Some((length(v604.clone())) - 1_i32),
                                );
                                let v661: string = ofChar(v618);
                                let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method87(
                                        Documents::method86(
                                            length(v661.clone()) as i64,
                                            v661,
                                            0_i64,
                                        ),
                                        v605.clone(),
                                        v606,
                                        v607,
                                    );
                                Documents::US16::US16_0(
                                    v618,
                                    v655,
                                    patternInput_4.0.clone(),
                                    patternInput_4.1.clone(),
                                    patternInput_4.2.clone(),
                                )
                            } else {
                                let v678: i32 = (indexOf(v604.clone(), string("\n"))) - 1_i32;
                                let v718: string = getSlice(
                                    v604.clone(),
                                    Some(0_i32),
                                    Some(
                                        (if -2_i32 == (v678) {
                                            (length(v604.clone())) + 1_i32
                                        } else {
                                            (v678) + 1_i32
                                        }) - 1_i32,
                                    ),
                                );
                                Documents::US16::US16_1(append(
                                    (append(
                                        (append(
                                            (append(
                                                (append(
                                                    (append(
                                                        (append(
                                                            string("parsing.p_char / "),
                                                            (Documents::method88(' ', v606, v607)),
                                                        )),
                                                        string("\n"),
                                                    )),
                                                    (toString(v605.clone())),
                                                )),
                                                (v718),
                                            )),
                                            string("\n"),
                                        )),
                                        (append(
                                            ((Documents::method89((v607) - 1_i32, 0_i32))(string(
                                                "",
                                            ))),
                                            string("^"),
                                        )),
                                    )),
                                    string("\n"),
                                ))
                            }
                        };
                        let v783: Documents::US21 = match &v771 {
                            Documents::US16::US16_0(
                                v771_0_0,
                                v771_0_1,
                                v771_0_2,
                                v771_0_3,
                                v771_0_4,
                            ) => Documents::US21::US21_0(
                                Documents::US18::US18_0(v771_0_0.clone()),
                                v771_0_1.clone(),
                                v771_0_2.clone(),
                                v771_0_3.clone(),
                                v771_0_4.clone(),
                            ),
                            _ => Documents::US21::US21_0(
                                Documents::US18::US18_1,
                                v604.clone(),
                                v605.clone(),
                                v606,
                                v607,
                            ),
                        };
                        let v874: Documents::US17 = match &v783 {
                            Documents::US21::US21_0(
                                v783_0_0,
                                v783_0_1,
                                v783_0_2,
                                v783_0_3,
                                v783_0_4,
                            ) => {
                                let v788: i32 = v783_0_4.clone();
                                let v787: i32 = v783_0_3.clone();
                                let v786: LrcPtr<StringBuilder> = v783_0_2.clone();
                                let v785: string = v783_0_1.clone();
                                let v850: Documents::US16 = if string("") == (v785.clone()) {
                                    Documents::US16::US16_1(append(
                                        string("parsing.any_char / unexpected end of input / "),
                                        (Documents::method102(v786.clone(), v787, v788)),
                                    ))
                                } else {
                                    let v798: char = getCharAt(v785.clone(), 0_i32);
                                    let v834: string = getSlice(
                                        v785.clone(),
                                        Some(1_i32),
                                        Some((length(v785)) - 1_i32),
                                    );
                                    let v840: string = ofChar(v798);
                                    let patternInput_5: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method87(
                                            Documents::method86(
                                                length(v840.clone()) as i64,
                                                v840,
                                                0_i64,
                                            ),
                                            v786,
                                            v787,
                                            v788,
                                        );
                                    Documents::US16::US16_0(
                                        v798,
                                        v834,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                    )
                                };
                                match &v850 {
                                    Documents::US16::US16_0(
                                        v850_0_0,
                                        v850_0_1,
                                        v850_0_2,
                                        v850_0_3,
                                        v850_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Documents::method103(
                                            ofChar(v850_0_0.clone()),
                                            v850_0_1.clone(),
                                            v850_0_2.clone(),
                                            v850_0_3.clone(),
                                            v850_0_4.clone(),
                                        );
                                        Documents::US17::US17_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Documents::US16::US16_1(v850_1_0) => {
                                        Documents::US17::US17_1(v850_1_0.clone())
                                    }
                                }
                            }
                            Documents::US21::US21_1(v783_1_0) => {
                                Documents::US17::US17_1(v783_1_0.clone())
                            }
                        };
                        let v886: Documents::US22 = match &v874 {
                            Documents::US17::US17_0(
                                v874_0_0,
                                v874_0_1,
                                v874_0_2,
                                v874_0_3,
                                v874_0_4,
                            ) => Documents::US22::US22_0(
                                Documents::US5::US5_0(v874_0_0.clone()),
                                v874_0_1.clone(),
                                v874_0_2.clone(),
                                v874_0_3.clone(),
                                v874_0_4.clone(),
                            ),
                            _ => Documents::US22::US22_0(
                                Documents::US5::US5_1,
                                v604.clone(),
                                v605.clone(),
                                v606,
                                v607,
                            ),
                        };
                        match &v886 {
                            Documents::US22::US22_0(
                                v886_0_0,
                                v886_0_1,
                                v886_0_2,
                                v886_0_3,
                                v886_0_4,
                            ) => Documents::US20::US20_0(
                                v602_0_0.clone(),
                                v886_0_0.clone(),
                                v886_0_1.clone(),
                                v886_0_2.clone(),
                                v886_0_3.clone(),
                                v886_0_4.clone(),
                            ),
                            Documents::US22::US22_1(v886_1_0) => {
                                Documents::US20::US20_1(v886_1_0.clone())
                            }
                        }
                    }
                    Documents::US17::US17_1(v602_1_0) => Documents::US20::US20_1(v602_1_0.clone()),
                };
                match &v900 {
                    Documents::US20::US20_0(
                        v900_0_0,
                        v900_0_1,
                        v900_0_2,
                        v900_0_3,
                        v900_0_4,
                        v900_0_5,
                    ) => Documents::US15::US15_0(v900_0_0.clone(), v900_0_1.clone()),
                    Documents::US20::US20_1(v900_1_0) => Documents::US15::US15_1(v900_1_0.clone()),
                }
            }
        }
        pub fn method106(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method106: loop {
                break '_method106 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US18::US18_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US18::US18_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US18::US18_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US18::US18_0(v19_0_0) => match &v19 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method106;
                    }
                });
            }
        }
        pub fn method107(
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
            '_method107: loop {
                break '_method107 ({
                    let v224: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.none_of / unexpected end of input / "),
                            (Documents::method92(
                                Documents::method91(toArray(ofArray(new_array(&[
                                    '\\', '`', '\"', ' ',
                                ])))),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v87: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method106(v87, 0_i64)) == false {
                            let v126: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v132: string = ofChar(v87);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    Documents::method86(length(v132.clone()) as i64, v132, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v87,
                                v126,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected char / "),
                                (Documents::method94(
                                    v87,
                                    Documents::method91(toArray(ofArray(new_array(&[
                                        '\\', '`', '\"', ' ',
                                    ])))),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                )),
                            ))
                        }
                    };
                    match &v224 {
                        Documents::US16::US16_0(
                            v224_0_0,
                            v224_0_1,
                            v224_0_2,
                            v224_0_3,
                            v224_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v224_0_0.clone())));
                            let v1_1_temp: string = v224_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v224_0_2.clone();
                            let v3_temp: i32 = v224_0_3.clone();
                            let v4_temp: i32 = v224_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method107;
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
        pub fn method109(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method109: loop {
                break '_method109 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US18::US18_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US18::US18_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US18::US18_0(v15_0_0) => match &v15 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method109;
                    }
                });
            }
        }
        pub fn closure39(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US17 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v168: Documents::US16 = if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(append(
                    string("parsing.p_char / unexpected end of input / "),
                    (Documents::method85('\\', v1_1.clone(), v2, v3)),
                ))
            } else {
                let v14: char = getCharAt(v0_1.clone(), 0_i32);
                if (v14) == '\\' {
                    let v51: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v57: string = ofChar(v14);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                        Documents::method86(length(v57.clone()) as i64, v57, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v14,
                        v51,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v74: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    let v114: string = getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(
                            (if -2_i32 == (v74) {
                                (length(v0_1)) + 1_i32
                            } else {
                                (v74) + 1_i32
                            }) - 1_i32,
                        ),
                    );
                    Documents::US16::US16_1(append(
                        (append(
                            (append(
                                (append(
                                    (append(
                                        (append(
                                            (append(
                                                string("parsing.p_char / "),
                                                (Documents::method88('\\', v2, v3)),
                                            )),
                                            string("\n"),
                                        )),
                                        (toString(v1_1)),
                                    )),
                                    (v114),
                                )),
                                string("\n"),
                            )),
                            (append(
                                ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                                string("^"),
                            )),
                        )),
                        string("\n"),
                    ))
                }
            };
            let v239: Documents::US16 = match &v168 {
                Documents::US16::US16_0(v168_0_0, v168_0_1, v168_0_2, v168_0_3, v168_0_4) => {
                    let v173: i32 = v168_0_4.clone();
                    let v172: i32 = v168_0_3.clone();
                    let v171: LrcPtr<StringBuilder> = v168_0_2.clone();
                    let v170: string = v168_0_1.clone();
                    if string("") == (v170.clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.any_char / unexpected end of input / "),
                            (Documents::method102(v171.clone(), v172, v173)),
                        ))
                    } else {
                        let v183: char = getCharAt(v170.clone(), 0_i32);
                        let v219: string =
                            getSlice(v170.clone(), Some(1_i32), Some((length(v170)) - 1_i32));
                        let v225: string = ofChar(v183);
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            Documents::method86(length(v225.clone()) as i64, v225, 0_i64),
                            v171,
                            v172,
                            v173,
                        );
                        Documents::US16::US16_0(
                            v183,
                            v219,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
                Documents::US16::US16_1(v168_1_0) => Documents::US16::US16_1(v168_1_0.clone()),
            };
            match &v239 {
                Documents::US16::US16_0(v239_0_0, v239_0_1, v239_0_2, v239_0_3, v239_0_4) => {
                    Documents::US17::US17_0(
                        append((ofChar('\\')), (ofChar(v239_0_0.clone()))),
                        v239_0_1.clone(),
                        v239_0_2.clone(),
                        v239_0_3.clone(),
                        v239_0_4.clone(),
                    )
                }
                Documents::US16::US16_1(v239_1_0) => Documents::US17::US17_1(v239_1_0.clone()),
            }
        }
        pub fn closure40(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US17 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v168: Documents::US16 = if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(append(
                    string("parsing.p_char / unexpected end of input / "),
                    (Documents::method85('`', v1_1.clone(), v2, v3)),
                ))
            } else {
                let v14: char = getCharAt(v0_1.clone(), 0_i32);
                if (v14) == '`' {
                    let v51: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v57: string = ofChar(v14);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                        Documents::method86(length(v57.clone()) as i64, v57, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v14,
                        v51,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v74: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    let v114: string = getSlice(
                        v0_1.clone(),
                        Some(0_i32),
                        Some(
                            (if -2_i32 == (v74) {
                                (length(v0_1)) + 1_i32
                            } else {
                                (v74) + 1_i32
                            }) - 1_i32,
                        ),
                    );
                    Documents::US16::US16_1(append(
                        (append(
                            (append(
                                (append(
                                    (append(
                                        (append(
                                            (append(
                                                string("parsing.p_char / "),
                                                (Documents::method88('`', v2, v3)),
                                            )),
                                            string("\n"),
                                        )),
                                        (toString(v1_1)),
                                    )),
                                    (v114),
                                )),
                                string("\n"),
                            )),
                            (append(
                                ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                                string("^"),
                            )),
                        )),
                        string("\n"),
                    ))
                }
            };
            let v239: Documents::US16 = match &v168 {
                Documents::US16::US16_0(v168_0_0, v168_0_1, v168_0_2, v168_0_3, v168_0_4) => {
                    let v173: i32 = v168_0_4.clone();
                    let v172: i32 = v168_0_3.clone();
                    let v171: LrcPtr<StringBuilder> = v168_0_2.clone();
                    let v170: string = v168_0_1.clone();
                    if string("") == (v170.clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.any_char / unexpected end of input / "),
                            (Documents::method102(v171.clone(), v172, v173)),
                        ))
                    } else {
                        let v183: char = getCharAt(v170.clone(), 0_i32);
                        let v219: string =
                            getSlice(v170.clone(), Some(1_i32), Some((length(v170)) - 1_i32));
                        let v225: string = ofChar(v183);
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            Documents::method86(length(v225.clone()) as i64, v225, 0_i64),
                            v171,
                            v172,
                            v173,
                        );
                        Documents::US16::US16_0(
                            v183,
                            v219,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
                Documents::US16::US16_1(v168_1_0) => Documents::US16::US16_1(v168_1_0.clone()),
            };
            match &v239 {
                Documents::US16::US16_0(v239_0_0, v239_0_1, v239_0_2, v239_0_3, v239_0_4) => {
                    Documents::US17::US17_0(
                        append((ofChar('`')), (ofChar(v239_0_0.clone()))),
                        v239_0_1.clone(),
                        v239_0_2.clone(),
                        v239_0_3.clone(),
                        v239_0_4.clone(),
                    )
                }
                Documents::US16::US16_1(v239_1_0) => Documents::US17::US17_1(v239_1_0.clone()),
            }
        }
        pub fn method110(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH3>,
        ) -> Documents::US17 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v4.clone());
            '_method110: loop {
                break '_method110 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US17::US17_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US17 = (match v4.get().clone().as_ref() {
                            Documents::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US17::US17_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
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
                                continue '_method110;
                            }
                        }
                    }
                });
            }
        }
        pub fn method111(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method111: loop {
                break '_method111 (match v0_1.get().clone().as_ref() {
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
                        continue '_method111;
                    }
                });
            }
        }
        pub fn method108(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US24 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method108: loop {
                break '_method108 ({
                    let v200: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.none_of / unexpected end of input / "),
                            (Documents::method92(
                                Documents::method91(toArray(ofArray(new_array(&[
                                    '\\', '`', '\"',
                                ])))),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v75: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method109(v75, 0_i64)) == false {
                            let v114: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v120: string = ofChar(v75);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    Documents::method86(length(v120.clone()) as i64, v120, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v75,
                                v114,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected char / "),
                                (Documents::method94(
                                    v75,
                                    Documents::method91(toArray(ofArray(new_array(&[
                                        '\\', '`', '\"',
                                    ])))),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                )),
                            ))
                        }
                    };
                    let v215: Documents::US17 = match &v200 {
                        Documents::US16::US16_0(
                            v200_0_0,
                            v200_0_1,
                            v200_0_2,
                            v200_0_3,
                            v200_0_4,
                        ) => Documents::US17::US17_0(
                            ofChar(v200_0_0.clone()),
                            v200_0_1.clone(),
                            v200_0_2.clone(),
                            v200_0_3.clone(),
                            v200_0_4.clone(),
                        ),
                        Documents::US16::US16_1(v200_1_0) => {
                            Documents::US17::US17_1(v200_1_0.clone())
                        }
                    };
                    let v229: Documents::US17 = match &v215 {
                        Documents::US17::US17_0(
                            v215_0_0,
                            v215_0_1,
                            v215_0_2,
                            v215_0_3,
                            v215_0_4,
                        ) => v215.clone(),
                        _ => Documents::method110(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure39((), arg10_0040)
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
                                            Documents::closure40((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v229 {
                        Documents::US17::US17_0(
                            v229_0_0,
                            v229_0_1,
                            v229_0_2,
                            v229_0_3,
                            v229_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v229_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v229_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v229_0_2.clone();
                            let v3_temp: i32 = v229_0_3.clone();
                            let v4_temp: i32 = v229_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method108;
                        }
                        _ => Documents::US24::US24_0(
                            Documents::method111(
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
        pub fn method112(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method112(
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
        pub fn method113(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US24 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method113: loop {
                break '_method113 ({
                    let v200: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(append(
                            string("parsing.none_of / unexpected end of input / "),
                            (Documents::method92(
                                Documents::method91(toArray(ofArray(new_array(&[
                                    '\\', '`', '\"',
                                ])))),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v75: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method109(v75, 0_i64)) == false {
                            let v114: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v120: string = ofChar(v75);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    Documents::method86(length(v120.clone()) as i64, v120, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v75,
                                v114,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected char / "),
                                (Documents::method94(
                                    v75,
                                    Documents::method91(toArray(ofArray(new_array(&[
                                        '\\', '`', '\"',
                                    ])))),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                )),
                            ))
                        }
                    };
                    let v215: Documents::US17 = match &v200 {
                        Documents::US16::US16_0(
                            v200_0_0,
                            v200_0_1,
                            v200_0_2,
                            v200_0_3,
                            v200_0_4,
                        ) => Documents::US17::US17_0(
                            ofChar(v200_0_0.clone()),
                            v200_0_1.clone(),
                            v200_0_2.clone(),
                            v200_0_3.clone(),
                            v200_0_4.clone(),
                        ),
                        Documents::US16::US16_1(v200_1_0) => {
                            Documents::US17::US17_1(v200_1_0.clone())
                        }
                    };
                    match &v215 {
                        Documents::US17::US17_0(
                            v215_0_0,
                            v215_0_1,
                            v215_0_2,
                            v215_0_3,
                            v215_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v215_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v215_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v215_0_2.clone();
                            let v3_temp: i32 = v215_0_3.clone();
                            let v4_temp: i32 = v215_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method113;
                        }
                        _ => Documents::US24::US24_0(
                            Documents::method111(
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
        pub fn method105(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US24 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method105: loop {
                break '_method105 ({
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v224: Documents::US16 = if v5 {
                        Documents::US16::US16_1(append(
                            string("parsing.none_of / unexpected end of input / "),
                            (Documents::method92(
                                Documents::method91(toArray(ofArray(new_array(&[
                                    '\\', '`', '\"', ' ',
                                ])))),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            )),
                        ))
                    } else {
                        let v87: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method106(v87, 0_i64)) == false {
                            let v126: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v132: string = ofChar(v87);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    Documents::method86(length(v132.clone()) as i64, v132, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v87,
                                v126,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(append(
                                string("parsing.none_of / unexpected char / "),
                                (Documents::method94(
                                    v87,
                                    Documents::method91(toArray(ofArray(new_array(&[
                                        '\\', '`', '\"', ' ',
                                    ])))),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                )),
                            ))
                        }
                    };
                    let v244: Documents::US17 = match &v224 {
                        Documents::US16::US16_0(
                            v224_0_0,
                            v224_0_1,
                            v224_0_2,
                            v224_0_3,
                            v224_0_4,
                        ) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method107(
                                    ofChar(v224_0_0.clone()),
                                    v224_0_1.clone(),
                                    v224_0_2.clone(),
                                    v224_0_3.clone(),
                                    v224_0_4.clone(),
                                );
                            Documents::US17::US17_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Documents::US16::US16_1(v224_1_0) => {
                            Documents::US17::US17_1(v224_1_0.clone())
                        }
                    };
                    let v721: Documents::US17 = match &v244 {
                        Documents::US17::US17_0(
                            v244_0_0,
                            v244_0_1,
                            v244_0_2,
                            v244_0_3,
                            v244_0_4,
                        ) => v244.clone(),
                        _ => {
                            let v414: Documents::US16 = if v5 {
                                Documents::US16::US16_1(append(
                                    string("parsing.p_char / unexpected end of input / "),
                                    (Documents::method85(
                                        '\"',
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    )),
                                ))
                            } else {
                                let v260: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if (v260) == '\"' {
                                    let v297: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some((length(v1_1.get().clone())) - 1_i32),
                                    );
                                    let v303: string = ofChar(v260);
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method87(
                                            Documents::method86(
                                                length(v303.clone()) as i64,
                                                v303,
                                                0_i64,
                                            ),
                                            v2.get().clone(),
                                            v3.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Documents::US16::US16_0(
                                        v260,
                                        v297,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                } else {
                                    let v320: i32 =
                                        (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                    let v360: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(0_i32),
                                        Some(
                                            (if -2_i32 == (v320) {
                                                (length(v1_1.get().clone())) + 1_i32
                                            } else {
                                                (v320) + 1_i32
                                            }) - 1_i32,
                                        ),
                                    );
                                    Documents::US16::US16_1(append(
                                        (append(
                                            (append(
                                                (append(
                                                    (append(
                                                        (append(
                                                            (append(
                                                                string("parsing.p_char / "),
                                                                (Documents::method88(
                                                                    '\"',
                                                                    v3.get().clone(),
                                                                    v4.get().clone(),
                                                                )),
                                                            )),
                                                            string("\n"),
                                                        )),
                                                        (toString(v2.get().clone())),
                                                    )),
                                                    (v360),
                                                )),
                                                string("\n"),
                                            )),
                                            (append(
                                                ((Documents::method89(
                                                    (v4.get().clone()) - 1_i32,
                                                    0_i32,
                                                ))(
                                                    string("")
                                                )),
                                                string("^"),
                                            )),
                                        )),
                                        string("\n"),
                                    ))
                                }
                            };
                            let v650: Documents::US17 = match &v414 {
                                Documents::US16::US16_0(
                                    v414_0_0,
                                    v414_0_1,
                                    v414_0_2,
                                    v414_0_3,
                                    v414_0_4,
                                ) => {
                                    let v419: i32 = v414_0_4.clone();
                                    let v418: i32 = v414_0_3.clone();
                                    let v417: LrcPtr<StringBuilder> = v414_0_2.clone();
                                    let v416: string = v414_0_1.clone();
                                    let v421: Documents::US24 = Documents::method108(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v416.clone(),
                                        v417.clone(),
                                        v418,
                                        v419,
                                    );
                                    let v454: Documents::US17 = match &v421 {
                                        Documents::US24::US24_0(
                                            v421_0_0,
                                            v421_0_1,
                                            v421_0_2,
                                            v421_0_3,
                                            v421_0_4,
                                        ) => {
                                            let v428: List<string> = Documents::method112(
                                                v421_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US17::US17_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v428 = v428.clone();
                                                        move || ofList(v428.clone()).clone()
                                                    }))),
                                                ),
                                                v421_0_1.clone(),
                                                v421_0_2.clone(),
                                                v421_0_3.clone(),
                                                v421_0_4.clone(),
                                            )
                                        }
                                        Documents::US24::US24_1(v421_1_0) => {
                                            Documents::US17::US17_1(v421_1_0.clone())
                                        }
                                    };
                                    match &v454 {
                                        Documents::US17::US17_0(
                                            v454_0_0,
                                            v454_0_1,
                                            v454_0_2,
                                            v454_0_3,
                                            v454_0_4,
                                        ) => {
                                            let v459: i32 = v454_0_4.clone();
                                            let v458: i32 = v454_0_3.clone();
                                            let v457: LrcPtr<StringBuilder> = v454_0_2.clone();
                                            let v456: string = v454_0_1.clone();
                                            let v624: Documents::US16 = if string("")
                                                == (v456.clone())
                                            {
                                                Documents::US16::US16_1(append(
                                                    string(
                                                        "parsing.p_char / unexpected end of input / ",
                                                    ),
                                                    (Documents::method85(
                                                        '\"',
                                                        v457.clone(),
                                                        v458,
                                                        v459,
                                                    )),
                                                ))
                                            } else {
                                                let v470: char = getCharAt(v456.clone(), 0_i32);
                                                if (v470) == '\"' {
                                                    let v507: string = getSlice(
                                                        v456.clone(),
                                                        Some(1_i32),
                                                        Some((length(v456.clone())) - 1_i32),
                                                    );
                                                    let v513: string = ofChar(v470);
                                                    let patternInput_3: (
                                                        LrcPtr<StringBuilder>,
                                                        i32,
                                                        i32,
                                                    ) = Documents::method87(
                                                        Documents::method86(
                                                            length(v513.clone()) as i64,
                                                            v513,
                                                            0_i64,
                                                        ),
                                                        v457.clone(),
                                                        v458,
                                                        v459,
                                                    );
                                                    Documents::US16::US16_0(
                                                        v470,
                                                        v507,
                                                        patternInput_3.0.clone(),
                                                        patternInput_3.1.clone(),
                                                        patternInput_3.2.clone(),
                                                    )
                                                } else {
                                                    let v530: i32 =
                                                        (indexOf(v456.clone(), string("\n")))
                                                            - 1_i32;
                                                    let v570: string = getSlice(
                                                        v456.clone(),
                                                        Some(0_i32),
                                                        Some(
                                                            (if -2_i32 == (v530) {
                                                                (length(v456.clone())) + 1_i32
                                                            } else {
                                                                (v530) + 1_i32
                                                            }) - 1_i32,
                                                        ),
                                                    );
                                                    Documents::US16::US16_1(append((append((append((append((append((append((append(string("parsing.p_char / "),
                                                                                                                                                        (Documents::method88('\"',
                                                                                                                                                                             v458,
                                                                                                                                                                             v459)))),
                                                                                                                                                string("\n"))),
                                                                                                                                        (toString(v457.clone())))),
                                                                                                                                (v570))),
                                                                                                                        string("\n"))),
                                                                                                                (append(((Documents::method89((v459)
                                                                                                                                                  -
                                                                                                                                                  1_i32,
                                                                                                                                              0_i32))(string(""))),
                                                                                                                        string("^"))))),
                                                                                                        string("\n")))
                                                }
                                            };
                                            match &v624 {
                                                Documents::US16::US16_0(
                                                    v624_0_0,
                                                    v624_0_1,
                                                    v624_0_2,
                                                    v624_0_3,
                                                    v624_0_4,
                                                ) => Documents::US17::US17_0(
                                                    v454_0_0.clone(),
                                                    v624_0_1.clone(),
                                                    v624_0_2.clone(),
                                                    v624_0_3.clone(),
                                                    v624_0_4.clone(),
                                                ),
                                                Documents::US16::US16_1(v624_1_0) => {
                                                    Documents::US17::US17_1(append(
                                                        string(
                                                            "parsing.between / expected closing delimiter / ",
                                                        ),
                                                        (Documents::method97(
                                                            v624_1_0.clone(),
                                                            v1_1.get().clone(),
                                                            v2.get().clone(),
                                                            v3.get().clone(),
                                                            v4.get().clone(),
                                                            v416.clone(),
                                                            v417.clone(),
                                                            v418,
                                                            v419,
                                                            v456.clone(),
                                                            v457.clone(),
                                                            v458,
                                                            v459,
                                                        )),
                                                    ))
                                                }
                                            }
                                        }
                                        _ => Documents::US17::US17_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Documents::US16::US16_1(v414_1_0) => {
                                    Documents::US17::US17_1(v414_1_0.clone())
                                }
                            };
                            match &v650 {
                                Documents::US17::US17_0(
                                    v650_0_0,
                                    v650_0_1,
                                    v650_0_2,
                                    v650_0_3,
                                    v650_0_4,
                                ) => v650.clone(),
                                _ => {
                                    let v662: Documents::US17 =
                                                     Documents::method110(v1_1.get().clone(),
                                                                          v2.get().clone(),
                                                                          v3.get().clone(),
                                                                          v4.get().clone(),
                                                                          LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                           |arg10_0040:
                                                                                                                                (string,
                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                 i32,
                                                                                                                                 i32)|
                                                                                                                           Documents::closure39((),
                                                                                                                                                arg10_0040)),
                                                                                                            LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                             |arg10_0040_1:
                                                                                                                                                                  (string,
                                                                                                                                                                   LrcPtr<StringBuilder>,
                                                                                                                                                                   i32,
                                                                                                                                                                   i32)|
                                                                                                                                                             Documents::closure40((),
                                                                                                                                                                                  arg10_0040_1)),
                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v673: Documents::US17 = match &v662 {
                                        Documents::US17::US17_0(
                                            v662_0_0,
                                            v662_0_1,
                                            v662_0_2,
                                            v662_0_3,
                                            v662_0_4,
                                        ) => Documents::US17::US17_0(
                                            string(""),
                                            v662_0_1.clone(),
                                            v662_0_2.clone(),
                                            v662_0_3.clone(),
                                            v662_0_4.clone(),
                                        ),
                                        Documents::US17::US17_1(v662_1_0) => {
                                            Documents::US17::US17_1(v662_1_0.clone())
                                        }
                                    };
                                    let v684: Documents::US24 = match &v673 {
                                        Documents::US17::US17_0(
                                            v673_0_0,
                                            v673_0_1,
                                            v673_0_2,
                                            v673_0_3,
                                            v673_0_4,
                                        ) => Documents::method113(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v673_0_1.clone(),
                                            v673_0_2.clone(),
                                            v673_0_3.clone(),
                                            v673_0_4.clone(),
                                        ),
                                        Documents::US17::US17_1(v673_1_0) => {
                                            Documents::US24::US24_1(v673_1_0.clone())
                                        }
                                    };
                                    match &v684 {
                                        Documents::US24::US24_0(
                                            v684_0_0,
                                            v684_0_1,
                                            v684_0_2,
                                            v684_0_3,
                                            v684_0_4,
                                        ) => {
                                            let v691: List<string> = Documents::method112(
                                                v684_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US17::US17_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v691 = v691.clone();
                                                        move || ofList(v691.clone()).clone()
                                                    }))),
                                                ),
                                                v684_0_1.clone(),
                                                v684_0_2.clone(),
                                                v684_0_3.clone(),
                                                v684_0_4.clone(),
                                            )
                                        }
                                        Documents::US24::US24_1(v684_1_0) => {
                                            Documents::US17::US17_1(v684_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v721 {
                        Documents::US17::US17_0(
                            v721_0_0,
                            v721_0_1,
                            v721_0_2,
                            v721_0_3,
                            v721_0_4,
                        ) => {
                            let v726: i32 = v721_0_4.clone();
                            let v725: i32 = v721_0_3.clone();
                            let v724: LrcPtr<StringBuilder> = v721_0_2.clone();
                            let v723: string = v721_0_1.clone();
                            let v722: string = v721_0_0.clone();
                            let v728: i32 = Documents::method101(v723.clone(), 0_i32);
                            let v772: Documents::US19 = if 0_i32 == (v728) {
                                Documents::US19::US19_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US19::US19_0(
                                    getSlice(
                                        v723.clone(),
                                        Some(v728),
                                        Some((length(v723.clone())) - 1_i32),
                                    ),
                                    v724.clone(),
                                    v725,
                                    v726,
                                )
                            };
                            match &v772 {
                                Documents::US19::US19_0(v772_0_0, v772_0_1, v772_0_2, v772_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v722.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v772_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v772_0_1.clone();
                                    let v3_temp: i32 = v772_0_2.clone();
                                    let v4_temp: i32 = v772_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method105;
                                }
                                _ => Documents::US24::US24_0(
                                    Documents::method111(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v722.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v723.clone(),
                                    v724.clone(),
                                    v725,
                                    v726,
                                ),
                            }
                        }
                        _ => Documents::US24::US24_0(
                            Documents::method111(
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
        pub fn method104(v0_1: string) -> Documents::US23 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v22: Documents::US24 = Documents::method105(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method84()),
                    1_i32,
                    1_i32,
                );
                match &v22 {
                    Documents::US24::US24_0(v22_0_0, v22_0_1, v22_0_2, v22_0_3, v22_0_4) => {
                        Documents::US23::US23_0(toArray(Documents::method112(
                            v22_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US24::US24_1(v22_1_0) => Documents::US23::US23_1(v22_1_0.clone()),
                }
            }
        }
        pub fn method115(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
            v9: bool,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("file_name"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v11.clone(), v0_1, ());
                ()
            };
            let v99: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v118: () = {
                Documents::closure8(v11.clone(), string("arguments"), ());
                ()
            };
            let v135: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v11.clone(), v1_1, ());
                ()
            };
            let v169: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v188: () = {
                Documents::closure8(v11.clone(), string("options"), ());
                ()
            };
            let v205: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v222: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v241: () = {
                Documents::closure8(v11.clone(), string("command"), ());
                ()
            };
            let v258: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v275: () = {
                Documents::closure8(v11.clone(), v2, ());
                ()
            };
            let v292: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v311: () = {
                Documents::closure8(v11.clone(), string("cancellation_token"), ());
                ()
            };
            let v328: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v340: std::string::String = format!("{:#?}", v3);
            let v387: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v340),
                    (),
                );
                ()
            };
            let v404: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v423: () = {
                Documents::closure8(v11.clone(), string("environment_variables"), ());
                ()
            };
            let v440: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v462: () = {
                Documents::closure8(v11.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v479: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v498: () = {
                Documents::closure8(v11.clone(), string("on_line"), ());
                ()
            };
            let v515: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v527: std::string::String = format!("{:#?}", v5);
            let v574: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v527),
                    (),
                );
                ()
            };
            let v591: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v610: () = {
                Documents::closure8(v11.clone(), string("stdin"), ());
                ()
            };
            let v627: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v639: std::string::String = format!("{:#?}", v6);
            let v686: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v639),
                    (),
                );
                ()
            };
            let v703: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v722: () = {
                Documents::closure8(v11.clone(), string("trace"), ());
                ()
            };
            let v739: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v759: () = {
                Documents::closure8(
                    v11.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v776: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v795: () = {
                Documents::closure8(v11.clone(), string("working_directory"), ());
                ()
            };
            let v812: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v824: std::string::String = format!("{:#?}", v8);
            let v871: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v824),
                    (),
                );
                ()
            };
            let v888: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v907: () = {
                Documents::closure8(v11.clone(), string("stderr"), ());
                ()
            };
            let v924: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v944: () = {
                Documents::closure8(
                    v11.clone(),
                    if v9 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v963: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v980: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            v11.l0.get().clone()
        }
        pub fn method114(
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
            v17: bool,
        ) -> string {
            let v18: string = Documents::method115(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options"),
                    )),
                    string(" / "),
                )),
                (v18),
            ))
        }
        pub fn closure41(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: string,
            v9: Vec<std::string::String>,
            unitVar: (),
        ) {
            fn v25() {
                Documents::closure6((), ());
            }
            let v26: () = {
                v25();
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
            let v67: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v311: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v90: () = {
                    v25();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v118: Option<i64> = patternInput_1.5.clone();
                let v117: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v116: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v115: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v114: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v113: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v137: string = Documents::method114(
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    Documents::method7(v113, v114, v115, v116, v117, v118),
                    Documents::method64(),
                    v8,
                    sprintf!("{:?}", v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v153: () = {
                    v25();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v177: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v176: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v198: () = {
                    Documents::closure9(v176.clone(), ());
                    ()
                };
                println!("{}", v137.clone());
                (v177.l0.get().clone())(v137);
                Documents::US6::US6_0(
                    v176,
                    v177,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure42(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method116() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US25 {
            Documents::US25::US25_0(v0_1)
        }
        pub fn method117()
        -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US25>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_1(v0_1)
        }
        pub fn method118() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn method120(
            v0_1: std::string::String,
            v1_1: string,
            v2: string,
            v3: string,
            v4: Option<CancellationToken>,
            v5: Array<(string, string)>,
            v6: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v7: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v8: bool,
            v9: Option<string>,
            v10: bool,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("error"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v76: std::string::String = format!("{:#?}", v0_1);
            let v123: () = {
                Documents::closure8(
                    v12.clone(),
                    fable_library_rust::String_::fromString(v76),
                    (),
                );
                ()
            };
            let v142: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v161: () = {
                Documents::closure8(v12.clone(), string("file_name"), ());
                ()
            };
            let v178: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v195: () = {
                Documents::closure8(v12.clone(), v1_1, ());
                ()
            };
            let v212: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v231: () = {
                Documents::closure8(v12.clone(), string("arguments"), ());
                ()
            };
            let v248: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v265: () = {
                Documents::closure8(v12.clone(), v2, ());
                ()
            };
            let v282: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v301: () = {
                Documents::closure8(v12.clone(), string("options"), ());
                ()
            };
            let v318: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v335: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v354: () = {
                Documents::closure8(v12.clone(), string("command"), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v388: () = {
                Documents::closure8(v12.clone(), v3, ());
                ()
            };
            let v405: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v424: () = {
                Documents::closure8(v12.clone(), string("cancellation_token"), ());
                ()
            };
            let v441: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v453: std::string::String = format!("{:#?}", v4);
            let v500: () = {
                Documents::closure8(
                    v12.clone(),
                    fable_library_rust::String_::fromString(v453),
                    (),
                );
                ()
            };
            let v517: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v536: () = {
                Documents::closure8(v12.clone(), string("environment_variables"), ());
                ()
            };
            let v553: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v575: () = {
                Documents::closure8(v12.clone(), sprintf!("{:?}", v5), ());
                ()
            };
            let v592: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v611: () = {
                Documents::closure8(v12.clone(), string("on_line"), ());
                ()
            };
            let v628: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v640: std::string::String = format!("{:#?}", v6);
            let v687: () = {
                Documents::closure8(
                    v12.clone(),
                    fable_library_rust::String_::fromString(v640),
                    (),
                );
                ()
            };
            let v704: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v723: () = {
                Documents::closure8(v12.clone(), string("stdin"), ());
                ()
            };
            let v740: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v752: std::string::String = format!("{:#?}", v7);
            let v799: () = {
                Documents::closure8(
                    v12.clone(),
                    fable_library_rust::String_::fromString(v752),
                    (),
                );
                ()
            };
            let v816: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v835: () = {
                Documents::closure8(v12.clone(), string("trace"), ());
                ()
            };
            let v852: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v872: () = {
                Documents::closure8(
                    v12.clone(),
                    if v8 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v889: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v908: () = {
                Documents::closure8(v12.clone(), string("working_directory"), ());
                ()
            };
            let v925: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v937: std::string::String = format!("{:#?}", v9);
            let v984: () = {
                Documents::closure8(
                    v12.clone(),
                    fable_library_rust::String_::fromString(v937),
                    (),
                );
                ()
            };
            let v1001: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v1020: () = {
                Documents::closure8(v12.clone(), string("stderr"), ());
                ()
            };
            let v1037: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v1057: () = {
                Documents::closure8(
                    v12.clone(),
                    if v10 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v1076: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            let v1093: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            v12.l0.get().clone()
        }
        pub fn method119(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: string,
            v12: Option<CancellationToken>,
            v13: Array<(string, string)>,
            v14: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v15: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v16: bool,
            v17: Option<string>,
            v18: bool,
        ) -> string {
            let v19: string =
                Documents::method120(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / child error"),
                    )),
                    string(" / "),
                )),
                (v19),
            ))
        }
        pub fn closure45(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: string,
            v9: Vec<std::string::String>,
            v10: std::string::String,
            unitVar: (),
        ) {
            fn v26() {
                Documents::closure6((), ());
            }
            let v27: () = {
                v26();
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
            let v68: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v312: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v91: () = {
                    v26();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v119: Option<i64> = patternInput_1.5.clone();
                let v118: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v117: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v116: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v115: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v114: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v138: string = Documents::method119(
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    v119.clone(),
                    Documents::method7(v114, v115, v116, v117, v118, v119),
                    Documents::method74(),
                    v10,
                    v8,
                    sprintf!("{:?}", v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v154: () = {
                    v26();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v178: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v177: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v199: () = {
                    Documents::closure9(v177.clone(), ());
                    ()
                };
                println!("{}", v138.clone());
                (v178.l0.get().clone())(v138);
                Documents::US6::US6_0(
                    v177,
                    v178,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method121(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure46(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method122()
        -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure46((), v))
        }
        pub fn closure47(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method123() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn method124() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn closure48(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method125() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure48((), v)
                },
            )
        }
        pub fn closure49(unitVar: (), v0_1: std::string::String) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method126() -> Func1<std::string::String, Documents::US27> {
            Func1::new(move |v: std::string::String| Documents::closure49((), v))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US27 {
            Documents::US27::US27_1(v0_1)
        }
        pub fn method127() -> Func1<std::string::String, Documents::US27> {
            Func1::new(move |v: std::string::String| Documents::closure50((), v))
        }
        pub fn method129(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("trace\'"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
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
            let v94: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v3.clone(), string("e"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v142: std::string::String = format!("{:#?}", v1_1);
            let v189: () = {
                Documents::closure8(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v142),
                    (),
                );
                ()
            };
            let v208: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method128(
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
            let v10: string = Documents::method129(v8, v9);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.stdio_line"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure51(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v59,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method128(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method74(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method130() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Verbose")), 0_i32));
            let v27: &str = inline_colorization::color_bright_black;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method132() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method131(
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
            let v9: string = Documents::method132();
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        (v8),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure52(v0_1: string, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method131(
                        v104.clone(),
                        v105.clone(),
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        Documents::method7(v104, v105, v106, v107, v108, v109),
                        Documents::method130(),
                        v0_1,
                    )
                };
                let v143: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure53(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method133()
        -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method134(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method135() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US28,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure54((), v)
                },
            )
        }
        pub fn method136(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure55(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method137()
        -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US29>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure55((), v)
                },
            )
        }
        pub fn method138(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure56(unitVar: (), v0_1: std::process::Output) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method139() -> Func1<std::process::Output, Documents::US30> {
            Func1::new(move |v: std::process::Output| Documents::closure56((), v))
        }
        pub fn closure57(unitVar: (), v0_1: std::string::String) -> Documents::US30 {
            Documents::US30::US30_1(v0_1)
        }
        pub fn method140() -> Func1<std::string::String, Documents::US30> {
            Func1::new(move |v: std::string::String| Documents::closure57((), v))
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
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: string,
            v12: Option<CancellationToken>,
            v13: Array<(string, string)>,
            v14: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v15: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v16: bool,
            v17: Option<string>,
            v18: bool,
        ) -> string {
            let v19: string =
                Documents::method120(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / output error"),
                    )),
                    string(" / "),
                )),
                (v19),
            ))
        }
        pub fn closure58(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: string,
            v9: Vec<std::string::String>,
            v10: std::string::String,
            unitVar: (),
        ) {
            fn v26() {
                Documents::closure6((), ());
            }
            let v27: () = {
                v26();
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
            let v68: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v312: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v91: () = {
                    v26();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v119: Option<i64> = patternInput_1.5.clone();
                let v118: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v117: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v116: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v115: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v114: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v138: string = Documents::method141(
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    v119.clone(),
                    Documents::method7(v114, v115, v116, v117, v118, v119),
                    Documents::method74(),
                    v10,
                    v8,
                    sprintf!("{:?}", v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v154: () = {
                    v26();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v178: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v177: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v199: () = {
                    Documents::closure9(v177.clone(), ());
                    ()
                };
                println!("{}", v138.clone());
                (v178.l0.get().clone())(v138);
                Documents::US6::US6_0(
                    v177,
                    v178,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure59(unitVar: (), v0_1: i32) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method142() -> Func1<i32, Documents::US31> {
            Func1::new(move |v: i32| Documents::closure59((), v))
        }
        pub fn method143() -> string {
            string("\n")
        }
        pub fn method145(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v3.clone(), string("std_trace_length"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v169: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method144(
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
            let v10: string = Documents::method145(v8, v9);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / result"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v59,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method144(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method130(),
                    v0_1,
                    length(v1_1),
                );
                let v142: () = {
                    v17();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method149(
            v0_1: string,
            v1_1: Documents::US5,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
            v9: bool,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("file_name"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v11.clone(), v0_1, ());
                ()
            };
            let v99: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v118: () = {
                Documents::closure8(v11.clone(), string("arguments"), ());
                ()
            };
            let v135: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v156: () = {
                Documents::closure8(v11.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v173: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v192: () = {
                Documents::closure8(v11.clone(), string("options"), ());
                ()
            };
            let v209: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v245: () = {
                Documents::closure8(v11.clone(), string("command"), ());
                ()
            };
            let v262: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v279: () = {
                Documents::closure8(v11.clone(), v2, ());
                ()
            };
            let v296: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v315: () = {
                Documents::closure8(v11.clone(), string("cancellation_token"), ());
                ()
            };
            let v332: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v344: std::string::String = format!("{:#?}", v3);
            let v391: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v344),
                    (),
                );
                ()
            };
            let v408: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v427: () = {
                Documents::closure8(v11.clone(), string("environment_variables"), ());
                ()
            };
            let v444: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v466: () = {
                Documents::closure8(v11.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v483: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v502: () = {
                Documents::closure8(v11.clone(), string("on_line"), ());
                ()
            };
            let v519: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v531: std::string::String = format!("{:#?}", v5);
            let v578: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v531),
                    (),
                );
                ()
            };
            let v595: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v614: () = {
                Documents::closure8(v11.clone(), string("stdin"), ());
                ()
            };
            let v631: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v643: std::string::String = format!("{:#?}", v6);
            let v690: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v643),
                    (),
                );
                ()
            };
            let v707: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v726: () = {
                Documents::closure8(v11.clone(), string("trace"), ());
                ()
            };
            let v743: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v763: () = {
                Documents::closure8(
                    v11.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v780: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v799: () = {
                Documents::closure8(v11.clone(), string("working_directory"), ());
                ()
            };
            let v816: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v828: std::string::String = format!("{:#?}", v8);
            let v875: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v828),
                    (),
                );
                ()
            };
            let v892: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v911: () = {
                Documents::closure8(v11.clone(), string("stderr"), ());
                ()
            };
            let v928: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v948: () = {
                Documents::closure8(
                    v11.clone(),
                    if v9 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v967: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v984: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            v11.l0.get().clone()
        }
        pub fn method148(
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
            v17: bool,
        ) -> string {
            let v18: string = Documents::method149(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async"),
                    )),
                    string(" / "),
                )),
                (v18),
            ))
        }
        pub fn closure61(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: Documents::US5,
            v9: string,
            unitVar: (),
        ) {
            fn v25() {
                Documents::closure6((), ());
            }
            let v26: () = {
                v25();
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
            let v67: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v307: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v90: () = {
                    v25();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v118: Option<i64> = patternInput_1.5.clone();
                let v117: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v116: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v115: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v114: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v113: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v133: string = Documents::method148(
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    Documents::method7(v113, v114, v115, v116, v117, v118),
                    Documents::method64(),
                    v9,
                    v8,
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v149: () = {
                    v25();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v173: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v172: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v194: () = {
                    Documents::closure9(v172.clone(), ());
                    ()
                };
                println!("{}", v133.clone());
                (v173.l0.get().clone())(v133);
                Documents::US6::US6_0(
                    v172,
                    v173,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method150(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> Array<(string, string)> {
            v2
        }
        pub fn method153(v0_1: bool) -> string {
            unbox::<string>(fable_library_rust::Native_::getZero())
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US32 {
            Documents::US32::US32_0(v0_1)
        }
        pub fn method154() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US32> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure63((), v)
            })
        }
        pub fn method155(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method131(
                        v104.clone(),
                        v105.clone(),
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        Documents::method7(v104, v105, v106, v107, v108, v109),
                        Documents::method130(),
                        v0_1,
                    )
                };
                let v143: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method152(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: bool,
            v9: LrcPtr<ConcurrentStack_1<string>>,
            v10: bool,
            v11: bool,
        ) -> Arc<Async<()>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method151(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: bool,
            v9: LrcPtr<ConcurrentStack_1<string>>,
            v10: bool,
            v11: bool,
        ) -> Arc<Async<()>> {
            Documents::method152(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
        }
        pub fn closure62(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: bool,
            v9: LrcPtr<ConcurrentStack_1<string>>,
            v10: bool,
            v11: bool,
        ) {
            let v12: Arc<Async<()>> =
                Documents::method151(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
            fable_library_rust::Native_::getZero::<()>();
            ()
        }
        pub fn closure65(unitVar: (), v0_1: CancellationToken) -> Documents::US33 {
            Documents::US33::US33_0(v0_1)
        }
        pub fn method156() -> Func1<CancellationToken, Documents::US33> {
            Func1::new(move |v: CancellationToken| Documents::closure65((), v))
        }
        pub fn method157(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method158(v0_1: bool) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method159(v0_1: bool) {
            ();
        }
        pub fn closure66(v0_1: bool, unitVar: ()) {
            if (Documents::method158(v0_1)) == false {
                Documents::method159(v0_1);
            };
        }
        pub fn method162(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("ex"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method161(
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
            let v9: string = Documents::method162(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async / WaitForExitAsync"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure67(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method161(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method33(),
                    v0_1,
                );
                let v140: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method160(
            v0_1: bool,
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method164(
            v0_1: i32,
            v1_1: i32,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
            v9: bool,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("exit_code"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v11.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v102: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v11.clone(), string("output_length"), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v158: () = {
                Documents::closure8(v11.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v175: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v194: () = {
                Documents::closure8(v11.clone(), string("options"), ());
                ()
            };
            let v211: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v228: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v247: () = {
                Documents::closure8(v11.clone(), string("command"), ());
                ()
            };
            let v264: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v281: () = {
                Documents::closure8(v11.clone(), v2, ());
                ()
            };
            let v298: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v317: () = {
                Documents::closure8(v11.clone(), string("cancellation_token"), ());
                ()
            };
            let v334: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v346: std::string::String = format!("{:#?}", v3);
            let v393: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v346),
                    (),
                );
                ()
            };
            let v410: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v429: () = {
                Documents::closure8(v11.clone(), string("environment_variables"), ());
                ()
            };
            let v446: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v468: () = {
                Documents::closure8(v11.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v485: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v504: () = {
                Documents::closure8(v11.clone(), string("on_line"), ());
                ()
            };
            let v521: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v533: std::string::String = format!("{:#?}", v5);
            let v580: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v533),
                    (),
                );
                ()
            };
            let v597: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v616: () = {
                Documents::closure8(v11.clone(), string("stdin"), ());
                ()
            };
            let v633: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v645: std::string::String = format!("{:#?}", v6);
            let v692: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v645),
                    (),
                );
                ()
            };
            let v709: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v728: () = {
                Documents::closure8(v11.clone(), string("trace"), ());
                ()
            };
            let v745: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v765: () = {
                Documents::closure8(
                    v11.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v782: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v801: () = {
                Documents::closure8(v11.clone(), string("working_directory"), ());
                ()
            };
            let v818: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v830: std::string::String = format!("{:#?}", v8);
            let v877: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v830),
                    (),
                );
                ()
            };
            let v894: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v913: () = {
                Documents::closure8(v11.clone(), string("stderr"), ());
                ()
            };
            let v930: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v950: () = {
                Documents::closure8(
                    v11.clone(),
                    if v9 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v969: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v986: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            v11.l0.get().clone()
        }
        pub fn method163(
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
            v17: bool,
        ) -> string {
            let v18: string = Documents::method164(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async"),
                    )),
                    string(" / "),
                )),
                (v18),
            ))
        }
        pub fn closure68(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: i32,
            v9: string,
            unitVar: (),
        ) {
            fn v25() {
                Documents::closure6((), ());
            }
            let v26: () = {
                v25();
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
            let v67: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v308: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v90: () = {
                    v25();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v118: Option<i64> = patternInput_1.5.clone();
                let v117: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v116: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v115: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v114: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v113: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v134: string = Documents::method163(
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    Documents::method7(v113, v114, v115, v116, v117, v118),
                    Documents::method64(),
                    v8,
                    length(v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v150: () = {
                    v25();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v174: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v173: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v195: () = {
                    Documents::closure9(v173.clone(), ());
                    ()
                };
                println!("{}", v134.clone());
                (v174.l0.get().clone())(v134);
                Documents::US6::US6_0(
                    v173,
                    v174,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method147(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> Arc<Async<(i32, string)>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method146(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> Arc<Async<(i32, string)>> {
            Documents::method147(v0_1, v1_1, v2, v3, v4, v5, v6, v7)
        }
        pub fn method81(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> (i32, string) {
            let v18: Documents::US15 = Documents::method83(Documents::method82(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
                v7,
            ));
            let patternInput: (string, Documents::US5) = match &v18 {
                Documents::US15::US15_0(v18_0_0, v18_0_1) => (v18_0_0.clone(), v18_0_1.clone()),
                Documents::US15::US15_1(v18_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Error x: "),
                        v18_1_0.clone()
                    ])),
                ),
            };
            let v31: Documents::US5 = patternInput.1.clone();
            let v30: string = patternInput.0.clone();
            let v36: Documents::US23 = Documents::method104(match &v31 {
                Documents::US5::US5_0(v31_0_0) => match &v31 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v45: Array<string> = match &v36 {
                Documents::US23::US23_0(v36_0_0) => v36_0_0.clone(),
                Documents::US23::US23_1(v36_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Error x: "),
                        v36_1_0.clone()
                    ])),
                ),
            };
            let v47: Vec<string> = v45.to_vec();
            let v49: bool = true;
            let _vec_map: Vec<_> = v47
                .into_iter()
                .map(|x| {
                    //;
                    let v51: string = x;
                    let v58: &str = &*v51;
                    let v94: std::string::String = String::from(v58);
                    let v125: bool = true;
                    v94
                })
                .collect::<Vec<_>>();
            let v127: Vec<std::string::String> = _vec_map;
            let v445: () = {
                Documents::closure41(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v7,
                    v30.clone(),
                    v127.clone(),
                    (),
                );
                ()
            };
            let _capture_v765: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
                    let v0_1 = v0_1.clone();
                    let v127 = v127.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v30 = v30.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v7 = v7.clone();
                    move || {
                        let v767: std::process::Command = std::process::Command::new(&*v30.clone());
                        let v769: bool = true;
                        let mut v767 = v767;
                        let v771: bool = true;
                        std::process::Command::args(&mut v767, &*v127.clone());
                        let v773: std::process::Command = v767;
                        let v775: std::process::Stdio = std::process::Stdio::piped();
                        let v777: bool = true;
                        let mut v773 = v773;
                        let v779: bool = true;
                        std::process::Command::stdout(&mut v773, std::process::Stdio::piped());
                        let v781: std::process::Command = v773;
                        let v783: std::process::Stdio = std::process::Stdio::piped();
                        let v785: bool = true;
                        let mut v781 = v781;
                        let v787: bool = true;
                        std::process::Command::stderr(&mut v781, std::process::Stdio::piped());
                        let v789: std::process::Command = v781;
                        let v791: std::process::Stdio = std::process::Stdio::piped();
                        let v793: bool = true;
                        let mut v789 = v789;
                        let v795: bool = true;
                        std::process::Command::stdin(&mut v789, std::process::Stdio::piped());
                        let v797: std::process::Command = v789;
                        let v822: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v838: std::process::Command = match &v822 {
                            Documents::US5::US5_0(v822_0_0) => {
                                let v828: bool = true;
                                let mut v797 = v797;
                                let v830: bool = true;
                                std::process::Command::current_dir(
                                    &mut v797,
                                    &*match &v822 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v797
                            }
                            _ => {
                                let v834: std::process::Command = v797;
                                v834
                            }
                        };
                        let v860: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v838
                        } else {
                            let v842: Vec<(string, string)> = v2.clone().to_vec();
                            let v844: bool = true;
                            let _vec_fold_ = v842.into_iter().fold(v838, |acc, x| {
                                //;
                                let v846: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v851: bool = true;
                                let mut v846 = v846;
                                let v853: bool = true;
                                std::process::Command::env(
                                    &mut v846,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v855: std::process::Command = v846;
                                let v857: bool = true;
                                v855
                            });
                            _vec_fold_
                        };
                        let v862: bool = true;
                        let mut v860 = v860;
                        let v864: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v860);
                        let v865 = Documents::method67();
                        let v869: Result<std::process::Child, std::string::String> =
                            v864.map_err(|x| v865(x));
                        let v881 = Documents::method116();
                        let v883: bool = true;
                        let _result_map_ = v869.map(|x| {
                            //;
                            let v890: Option<std::process::Child> = v881(Some(x));
                            let v892: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v890);
                            let v894: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v892);
                            let v896: bool = true;
                            v894
                        });
                        let v898: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v899 = Documents::method117();
                        let v900 = Documents::method118();
                        let v902: Documents::US25 = match v898 {
                            Ok(x) => v899(x),
                            Err(e) => v900(e),
                        };
                        let patternInput_3: (i32, Documents::US7, Documents::US26) = match &v902 {
                            Documents::US25::US25_0(v902_0_0) => {
                                let v903: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v902_0_0.clone();
                                let v905: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v907: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v903.clone();
                                    let v909: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v907.lock();
                                    let v925: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method121(v909.unwrap());
                                    let v927: bool = true;
                                    let mut v925 = v925;
                                    let v929: &mut Option<std::process::Child> = &mut v925;
                                    let v931: Option<&mut std::process::Child> = v929.as_mut();
                                    let v933: &mut std::process::Child = v931.unwrap();
                                    let v935: &mut Option<std::process::ChildStdout> =
                                        &mut v933.stdout;
                                    let v937: Option<std::process::ChildStdout> =
                                        Option::take(v935);
                                    let v939: std::process::ChildStdout = v937.unwrap();
                                    let v941: bool = true;
                                    v939
                                })();
                                let v943: std::process::ChildStdout = _capture;
                                let v945: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v947: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v903.clone();
                                    let v949: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v947.lock();
                                    let v965: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method121(v949.unwrap());
                                    let v967: bool = true;
                                    let mut v965 = v965;
                                    let v969: &mut Option<std::process::Child> = &mut v965;
                                    let v971: Option<&mut std::process::Child> = v969.as_mut();
                                    let v973: &mut std::process::Child = v971.unwrap();
                                    let v975: &mut Option<std::process::ChildStderr> =
                                        &mut v973.stderr;
                                    let v977: Option<std::process::ChildStderr> =
                                        Option::take(v975);
                                    let v979: std::process::ChildStderr = v977.unwrap();
                                    let v981: bool = true;
                                    v979
                                })();
                                let v983: std::process::ChildStderr = _capture;
                                let v985: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v987: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v903.clone();
                                    let v989: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v987.lock();
                                    let v1005: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method121(v989.unwrap());
                                    let v1007: bool = true;
                                    let mut v1005 = v1005;
                                    let v1009: &mut Option<std::process::Child> = &mut v1005;
                                    let v1011: Option<&mut std::process::Child> = v1009.as_mut();
                                    let v1013: &mut std::process::Child = v1011.unwrap();
                                    let v1015: &mut Option<std::process::ChildStdin> =
                                        &mut v1013.stdin;
                                    let v1017: Option<std::process::ChildStdin> =
                                        Option::take(v1015);
                                    let v1019: std::process::ChildStdin = v1017.unwrap();
                                    let v1025: Option<std::process::ChildStdin> =
                                        (Documents::method122())(Some(v1019));
                                    let v1027: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v1025);
                                    let v1029: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v1027);
                                    let v1031: bool = true;
                                    v1029
                                })();
                                let v1033: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v1035: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v1038: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method123())(v1035.clone());
                                let v1040: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1038);
                                let v1042: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1040);
                                let v1044: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method124())(v1035);
                                let v1046: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1044);
                                let v1048: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1046);
                                let v1050: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method125())(patternInput_2.1.clone());
                                let v1052: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v1050);
                                let v1054: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v1052);
                                let v1056: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v1058: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v943);
                                    let v1060: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1058);
                                    let v1062: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1060);
                                    let v1064: bool = true;
                                    let mut v1062 = v1062;
                                    let _iter_try_for_each = v1062.try_for_each(|x| {
                                        //;
                                        let v1066: Result<std::string::String, std::io::Error> = x;
                                        let v1068: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1042.clone();
                                        let v1069 = Documents::method67();
                                        let v1073: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1066.map_err(|x| v1069(x));
                                        let v1085 = Documents::method126();
                                        let v1086 = Documents::method127();
                                        let v1088: Documents::US27 = match v1073 {
                                            Ok(x) => v1085(x),
                                            Err(e) => v1086(e),
                                        };
                                        let v2496: std::string::String = match &v1088 {
                                            Documents::US27::US27_0(v1088_0_0) => {
                                                let v1091: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1088_0_0.clone(),
                                                    );
                                                let v1093: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1095: std::borrow::Cow<[u8]> =
                                                    v1093.encode(&*v1091).0;
                                                let v1097: &[u8] = v1095.as_ref();
                                                let v1099: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1097);
                                                let v1103: &str = v1099.unwrap();
                                                let v1142: std::string::String =
                                                    String::from(v1103);
                                                let v1153: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v1142.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v1470: () = {
                                                        Documents::closure52(v1153.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v1791: () = {
                                                        Documents::closure11(v1153, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v1142
                                            }
                                            Documents::US27::US27_1(v1088_1_0) => {
                                                let v1793: std::string::String = v1088_1_0.clone();
                                                let v2107: () = {
                                                    Documents::closure51(v5, v1793.clone(), ());
                                                    ()
                                                };
                                                let v2422: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v1793);
                                                let v2429: &str = &*v2422;
                                                String::from(v2429)
                                            }
                                        };
                                        let v2498: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1068;
                                        let v2500: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v2498.lock();
                                        let v2504: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v2500.unwrap();
                                        let v2517: &std::sync::mpsc::Sender<std::string::String> =
                                            &v2504;
                                        let v2519: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v2517.send(v2496);
                                        let v2520 = Documents::method133();
                                        let v2524: Result<(), std::string::String> =
                                            v2519.map_err(|x| v2520(x));
                                        let v2537: _ = v2524;
                                        let v2539: bool = true;
                                        v2537
                                    }); //;
                                    let v2542: Result<(), string> = Documents::method134(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v2545: string = string("}");
                                    let v2550: bool = true;
                                    let _fix_closure_v2547 = v2542;
                                    let v2556: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v2547 "),
                                                    (v2545),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v2557: bool = true;
                                    _fix_closure_v2547
                                }); // rust.fix_closure';
                                let v2559: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v2561: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v2563: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v983);
                                    let v2565: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v2563);
                                    let v2567: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v2565);
                                    let v2569: bool = true;
                                    let mut v2567 = v2567;
                                    let _iter_try_for_each = v2567.try_for_each(|x| {
                                        //;
                                        let v2571: Result<std::string::String, std::io::Error> = x;
                                        let v4109: Result<(), std::string::String> = if (v7)
                                            == false
                                        {
                                            Ok::<(), std::string::String>(())
                                        } else {
                                            let v2578: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v1048.clone();
                                            let v2579 = Documents::method67();
                                            let v2583: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v2571.map_err(|x| v2579(x));
                                            let v2595 = Documents::method126();
                                            let v2596 = Documents::method127();
                                            let v2598: Documents::US27 = match v2583 {
                                                Ok(x) => v2595(x),
                                                Err(e) => v2596(e),
                                            };
                                            let v4069: std::string::String = match &v2598 {
                                                Documents::US27::US27_0(v2598_0_0) => {
                                                    let v2601: string =
                                                        fable_library_rust::String_::fromString(
                                                            v2598_0_0.clone(),
                                                        );
                                                    let v2603: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v2605: std::borrow::Cow<[u8]> =
                                                        v2603.encode(&*v2601).0;
                                                    let v2607: &[u8] = v2605.as_ref();
                                                    let v2609: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v2607);
                                                    let v2613: &str = v2609.unwrap();
                                                    let v2652: std::string::String =
                                                        String::from(v2613);
                                                    let v2663: string = concat(new_array(&[
                                                        string("! "),
                                                        fable_library_rust::String_::fromString(
                                                            v2652.clone(),
                                                        ),
                                                    ]));
                                                    if v5 {
                                                        let v2977: () = {
                                                            Documents::closure52(v2663.clone(), ());
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v3295: () = {
                                                            Documents::closure11(v2663, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    {
                                                        let v3297: string = sprintf!(
                                                            "\u{001b}[4;7m{}\u{001b}[0m",
                                                            v2652
                                                        );
                                                        let v3304: &str = &*v3297;
                                                        String::from(v3304)
                                                    }
                                                }
                                                Documents::US27::US27_1(v2598_1_0) => {
                                                    let v3370: std::string::String =
                                                        v2598_1_0.clone();
                                                    let v3682: () = {
                                                        Documents::closure51(v5, v3370.clone(), ());
                                                        ()
                                                    };
                                                    let v3995: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v3370
                                                    );
                                                    let v4002: &str = &*v3995;
                                                    String::from(v4002)
                                                }
                                            };
                                            let v4071: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v2578;
                                            let v4073: Result<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = v4071.lock();
                                            let v4077: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v4073.unwrap();
                                            let v4090: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v4077;
                                            let v4092: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v4090.send(v4069);
                                            let v4093 = Documents::method133();
                                            v4092.map_err(|x| v4093(x))
                                        };
                                        let v4111: _ = v4109;
                                        let v4113: bool = true;
                                        v4111
                                    }); //;
                                    let v4116: Result<(), string> = Documents::method134(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v4117: string = string("}");
                                    let v4122: bool = true;
                                    let _fix_closure_v4119 = v4116;
                                    let v4128: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v4119 "),
                                                    (v4117),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v4129: bool = true;
                                    _fix_closure_v4119
                                }); // rust.fix_closure';
                                let v4131: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v4156: Documents::US28 = defaultValue(
                                    Documents::US28::US28_1,
                                    map(Documents::method135(), v4.clone()),
                                );
                                match &v4156 {
                                    Documents::US28::US28_0(v4156_0_0) => {
                                        let v4162: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v1033.clone();
                                        let v4164: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v4162.lock();
                                        let v4180: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method136(v4164.unwrap());
                                        let v4182: bool = true;
                                        let mut v4180 = v4180;
                                        let v4184: &mut Option<std::process::ChildStdin> =
                                            &mut v4180;
                                        let v4186: Option<std::process::ChildStdin> =
                                            Option::take(v4184);
                                        let v4188: bool = true;
                                        let _optionm_map_ = v4186.map(|x| {
                                            //;
                                            let v4190: std::process::ChildStdin = x;
                                            let v4192: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v4190);
                                            let v4194: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v4192);
                                            let v4196: bool = true;
                                            v4194
                                        });
                                        let v4198: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v4223: Documents::US29 = defaultValue(
                                            Documents::US29::US29_1,
                                            map(Documents::method137(), v4198),
                                        );
                                        match &v4223 {
                                            Documents::US29::US29_0(v4223_0_0) => {
                                                let v4227: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v4223 {
                                                    Documents::US29::US29_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v4156 {
                                                    Documents::US28::US28_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v4227.clone()
                                                );
                                                {
                                                    let v4229: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v4227;
                                                    let v4231: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v4229.lock();
                                                    let v4247: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method138(v4231.unwrap());
                                                    let v4249: bool = true;
                                                    let mut v4247 = v4247;
                                                    let v4251: bool = true;
                                                    std::io::Write::flush(&mut *v4247).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v4253: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v903;
                                    let v4255: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v4253.lock();
                                    let v4271: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method121(v4255.unwrap());
                                    let v4273: bool = true;
                                    let mut v4271 = v4271;
                                    let v4275: &mut Option<std::process::Child> = &mut v4271;
                                    let v4277: Option<std::process::Child> = Option::take(v4275);
                                    let v4279: std::process::Child = v4277.unwrap();
                                    let v4281: Result<std::process::Output, std::io::Error> =
                                        v4279.wait_with_output();
                                    let v4282 = Documents::method67();
                                    let v4295: Result<std::process::Output, std::string::String> =
                                        v4281.map_err(|x| v4282(x));
                                    let v4305: string = string("vec![v2559, v4131]");
                                    let v4306: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v2559, v4131];
                                    let v4308: bool = true;
                                    v4306.into_iter().for_each(|x| {
                                        //;
                                        let v4310: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v4312: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v4310);
                                        let v4316: Result<(), string> = v4312.unwrap();
                                        v4316.unwrap();
                                        {
                                            let v4333: bool = true;
                                            let v4335: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v4336 = Documents::method139();
                                        let v4337 = Documents::method140();
                                        let v4339: Documents::US30 = match &v4295 {
                                            Err(v4295_1_0) => v4337(v4295_1_0.clone()),
                                            Ok(v4295_0_0) => v4336(v4295_0_0.clone()),
                                        };
                                        match &v4339 {
                                            Documents::US30::US30_0(v4339_0_0) => {
                                                let v4344: std::process::ExitStatus =
                                                    v4339_0_0.clone().status;
                                                let v4346: Option<i32> = v4344.code();
                                                let v4371: Documents::US31 = defaultValue(
                                                    Documents::US31::US31_1,
                                                    map(Documents::method142(), v4346),
                                                );
                                                match &v4371 {
                                                    Documents::US31::US31_0(v4371_0_0) => (
                                                        match &v4371 {
                                                            Documents::US31::US31_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US7::US7_1,
                                                        Documents::US26::US26_0(v1054.clone()),
                                                    ),
                                                    _ => {
                                                        let v4385: &str = &*string(
                                                            "runtime.execute_with_options / exit_code=None",
                                                        );
                                                        (
                                                            -1_i32,
                                                            Documents::US7::US7_0(String::from(
                                                                v4385,
                                                            )),
                                                            Documents::US26::US26_0(v1054.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US30::US30_1(v4339_1_0) => {
                                                let v4459: std::string::String = v4339_1_0.clone();
                                                let v4775: () = {
                                                    Documents::closure58(
                                                        v0_1.clone(),
                                                        v1_1.clone(),
                                                        v2.clone(),
                                                        v3.clone(),
                                                        v4.clone(),
                                                        v5,
                                                        v6.clone(),
                                                        v7,
                                                        v30.clone(),
                                                        v127.clone(),
                                                        v4459.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US7::US7_0(v4459),
                                                    Documents::US26::US26_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US25::US25_1(v902_1_0) => {
                                let v5100: std::string::String = v902_1_0.clone();
                                let v5418: () = {
                                    Documents::closure45(
                                        v0_1.clone(),
                                        v1_1.clone(),
                                        v2.clone(),
                                        v3.clone(),
                                        v4.clone(),
                                        v5,
                                        v6.clone(),
                                        v7,
                                        v30.clone(),
                                        v127.clone(),
                                        v5100.clone(),
                                        (),
                                    );
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US7::US7_0(v5100),
                                    Documents::US26::US26_1,
                                )
                            }
                        };
                        let v5744: Documents::US26 = patternInput_3.2.clone();
                        let v5743: Documents::US7 = patternInput_3.1.clone();
                        let v5742: i32 = patternInput_3.0.clone();
                        let v5755: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v5744 {
                            Documents::US26::US26_0(v5744_0_0) => Some(
                                match &v5744 {
                                    Documents::US26::US26_0(x) => x.clone(),
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
                        let v5757: bool = true;
                        let _optionm_map_ = v5755.map(|x| {
                            //;
                            let v5759: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v5761: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v5759;
                            let v5763: Result<
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
                            > = v5761.lock();
                            let v5767: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v5763.unwrap();
                            let v5780 = v5767.iter();
                            let v5782: Vec<std::string::String> = v5780.collect::<Vec<_>>();
                            let v5784: bool = true;
                            let _vec_map: Vec<_> = v5782
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v5786: std::string::String = x;
                                    let v5788: string =
                                        fable_library_rust::String_::fromString(v5786);
                                    let v5790: bool = true;
                                    v5788
                                })
                                .collect::<Vec<_>>();
                            let v5792: Vec<string> = _vec_map;
                            let v5796: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v5792.clone()),
                            );
                            let v5804: string = join(Documents::method143(), toArray_1(v5796));
                            let v5809: bool = true;
                            v5804
                        });
                        let v5811: Option<string> = _optionm_map_;
                        let v5818: Documents::US5 = match &v5743 {
                            Documents::US7::US7_0(v5743_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v5743 {
                                        Documents::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v5824: string = defaultValue(
                            match &v5818 {
                                Documents::US5::US5_0(v5818_0_0) => match &v5818 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v5811,
                        );
                        let v6141: () = {
                            Documents::closure60(v5742, v5824.clone(), ());
                            ()
                        };
                        LrcPtr::new((v5742, v5824))
                    }
                }))();
                _capture_v765.set(Some(x_5))
            }
            {
                let v6461: LrcPtr<(i32, string)> = match &_capture_v765.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v765=None"),),
                    Some(_capture_v765_0_0) => _capture_v765_0_0.clone(),
                };
                let _run_target_args__v16: (i32, string) = (v6461.0.clone(), v6461.1.clone());
                (
                    _run_target_args__v16.0.clone(),
                    _run_target_args__v16.1.clone(),
                )
            }
        }
        pub fn method165(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method26(v2, Documents::method45(v1_1.clone()));
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
            let v26: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v26 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v9, string("."), v0_1.clone()]))
                },
                if v26 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v16, string("."), v0_1]))
                },
            )
        }
        pub fn method166() -> string {
            string("")
        }
        pub fn closure69(unitVar: (), v0_1: string) -> Documents::US35 {
            Documents::US35::US35_0(v0_1)
        }
        pub fn method167() -> Func1<string, Documents::US35> {
            Func1::new(move |v: string| Documents::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method168() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure70((), v))
        }
        pub fn method170(
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
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("file"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v12.clone(), v0_1, ());
                ()
            };
            let v100: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v12.clone(), string("real_path"), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v153: () = {
                Documents::closure8(v12.clone(), v1_1, ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v189: () = {
                Documents::closure8(v12.clone(), string("relative_path"), ());
                ()
            };
            let v206: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v223: () = {
                Documents::closure8(v12.clone(), v2, ());
                ()
            };
            let v240: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v259: () = {
                Documents::closure8(v12.clone(), string("origin_hash_exit_code"), ());
                ()
            };
            let v276: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v296: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v313: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v332: () = {
                Documents::closure8(v12.clone(), string("origin_hash"), ());
                ()
            };
            let v349: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v366: () = {
                Documents::closure8(v12.clone(), v4, ());
                ()
            };
            let v383: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v402: () = {
                Documents::closure8(v12.clone(), string("local_git_hash_exit_code"), ());
                ()
            };
            let v419: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v439: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v456: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v475: () = {
                Documents::closure8(v12.clone(), string("local_git_hash"), ());
                ()
            };
            let v492: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v509: () = {
                Documents::closure8(v12.clone(), v6, ());
                ()
            };
            let v526: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v545: () = {
                Documents::closure8(v12.clone(), string("hash1"), ());
                ()
            };
            let v562: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v579: () = {
                Documents::closure8(v12.clone(), v7, ());
                ()
            };
            let v596: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v615: () = {
                Documents::closure8(v12.clone(), string("hash2"), ());
                ()
            };
            let v632: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v653: () = {
                Documents::closure8(v12.clone(), sprintf!("{:?}", v8), ());
                ()
            };
            let v670: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v689: () = {
                Documents::closure8(v12.clone(), string("dist_path"), ());
                ()
            };
            let v706: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v723: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v740: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v759: () = {
                Documents::closure8(v12.clone(), string("cache_path"), ());
                ()
            };
            let v776: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v793: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v812: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            v12.l0.get().clone()
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
                Documents::method170(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        (v8),
                    )),
                    string(" / "),
                )),
                (v20),
            ))
        }
        pub fn closure71(
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
            fn v26() {
                Documents::closure6((), ());
            }
            let v27: () = {
                v26();
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
            let v68: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v316: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v91: () = {
                    v26();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v119: Option<i64> = patternInput_1.5.clone();
                let v118: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v117: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v116: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v115: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v114: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v138: string = string(
                    "documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2",
                );
                let v142: string = if (v138.clone()) == string("") {
                    string("")
                } else {
                    Documents::method169(
                        v114.clone(),
                        v115.clone(),
                        v116.clone(),
                        v117.clone(),
                        v118.clone(),
                        v119.clone(),
                        Documents::method7(v114, v115, v116, v117, v118, v119),
                        Documents::method11(),
                        v138,
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
                };
                let v158: () = {
                    v26();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v182: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v181: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v203: () = {
                    Documents::closure9(v181.clone(), ());
                    ()
                };
                println!("{}", v142.clone());
                (v182.l0.get().clone())(v142);
                Documents::US6::US6_0(
                    v181,
                    v182,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure72(unitVar: (), v0_1: u64) -> Documents::US36 {
            Documents::US36::US36_0(v0_1)
        }
        pub fn method172() -> Func1<u64, Documents::US36> {
            Func1::new(move |v: u64| Documents::closure72((), v))
        }
        pub fn closure73(unitVar: (), v0_1: std::string::String) -> Documents::US36 {
            Documents::US36::US36_1(v0_1)
        }
        pub fn method173() -> Func1<std::string::String, Documents::US36> {
            Func1::new(move |v: std::string::String| Documents::closure73((), v))
        }
        pub fn method175(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v92: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v111: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v162: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v181: () = {
                Documents::closure8(v4.clone(), string("error"), ());
                ()
            };
            let v198: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v210: std::string::String = format!("{:#?}", v2);
            let v257: () = {
                Documents::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v210),
                    (),
                );
                ()
            };
            let v276: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method174(
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
            let v11: string = Documents::method175(v8, v9, v10);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.file_copy"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure74(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method174(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method33(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v142: () = {
                    v18();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method177(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v92: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v111: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v162: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v181: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v198: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v218: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v237: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method176(
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
            let v11: string = Documents::method177(v8, v9, v10);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.file_copy"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure75(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method176(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method64(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v142: () = {
                    v18();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method171(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method67();
            let v18: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v21 = Documents::method172();
            let v22 = Documents::method173();
            let v24: Documents::US36 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v24 {
                Documents::US36::US36_0(v24_0_0) => {
                    let v341: () = {
                        Documents::closure75(v0_1.clone(), v1_1.clone(), v24_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US36::US36_1(v24_1_0) => {
                    let v970: () = {
                        Documents::closure74(v0_1.clone(), v1_1.clone(), v24_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method179(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method180(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method181(v0_1: string) -> string {
            v0_1
        }
        pub fn method182(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure78(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v21: string = Documents::method181(v0_1);
            let v23: &[u8] = v21.as_bytes();
            let v24: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method182(v9);
            let v26: bool = true;
            let mut v24 = v24;
            let v28: bool = true;
            std::io::Write::write_all(&mut *v24, v23).unwrap();
            ()
        }
        pub fn method183(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method185(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v4.clone(), string("result_len"), ());
                ()
            };
            let v131: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v204: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v221: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v240: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
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
            v8: i32,
            v9: i32,
            v10: string,
        ) -> string {
            let v11: string = Documents::method185(v8, v9, v10);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.hangul"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure79(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = Documents::method184(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method11(),
                    v1_1,
                    length(v2),
                    v0_1,
                );
                let v143: () = {
                    v18();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method178(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US37 {
            let v15: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v63: Vec<u8> = Documents::method179(v15.unwrap());
            let v65: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v63);
            let v69: std::string::String = v65.unwrap();
            let v124: Array<string> = split(
                fable_library_rust::String_::fromString(v69),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v127: i32 = get_Count(v124.clone());
            let v128: Array<string> = new_init(&string(""), v127);
            let v129: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method61(v127, v129.clone()) {
                let v131: i32 = v129.l0.get().clone();
                let v135: string = trim(v124[v131].clone());
                v128.get_mut()[v131 as usize] = v135;
                {
                    let v138: i32 = (v131) + 1_i32;
                    v129.l0.set(v138);
                    ()
                }
            }
            {
                let v139: i32 = get_Count(v128.clone());
                let v140: Array<string> = new_init(&string(""), v139);
                let v141: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method180(v139, v141.clone()) {
                    let v143: i32 = v141.l0.get().clone();
                    let v144: i32 = v141.l1.get().clone();
                    let v145: string = v128[v143].clone();
                    let v153: i32 = if (v145.clone()) != string("") {
                        v140.get_mut()[v144 as usize] = v145;
                        (v144) + 1_i32
                    } else {
                        v144
                    };
                    let v154: i32 = (v143) + 1_i32;
                    v141.l0.set(v154);
                    v141.l1.set(v153);
                    ()
                }
                {
                    let v155: i32 = v141.l1.get().clone();
                    let v156: Array<string> = new_init(&string(""), v155);
                    let v157: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method61(v155, v157.clone()) {
                        let v159: i32 = v157.l0.get().clone();
                        let v160: string = v140[v159].clone();
                        v156.get_mut()[v159 as usize] = v160;
                        {
                            let v161: i32 = (v159) + 1_i32;
                            v157.l0.set(v161);
                            ()
                        }
                    }
                    {
                        let _let__v166: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v156 = v156.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v156 = v156.clone();
                                        move |i: i32| v156[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v156.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v182: string = concat(new_array(&[
                            join(Documents::method143(), toArray_1(_let__v166)),
                            string("\n\n"),
                        ]));
                        let v197: string = if if contains(v182.clone(), string(" the ")) {
                            contains(v182.clone(), string(" and "))
                        } else {
                            false
                        } {
                            string("eng")
                        } else {
                            v1_1
                        };
                        let patternInput: (i32, string) = Documents::method81(
                            concat(new_array(&[
                                Documents::method26(
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
                                v197,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v182 = v182.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure78(v182.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                            true,
                        );
                        let v261: i32 = patternInput.0.clone();
                        let v272: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v275: i32 = get_Count(v272.clone());
                        let v277: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method183(v139, v277.clone()) {
                            let v279: i32 = v277.l0.get().clone();
                            let matchValue: string = v277.l1.get().clone();
                            let matchValue_1: i32 = v277.l2.get().clone();
                            let v282: i32 = v277.l3.get().clone();
                            let v281: i32 = matchValue_1;
                            let v280: string = matchValue;
                            let v283: string = v128[v279].clone();
                            let patternInput_2: (string, i32, i32) = if (v283.clone()) == string("")
                            {
                                (
                                    concat(new_array(&[v280.clone(), string("\n")])),
                                    (v281) + 1_i32,
                                    (v282) + 1_i32,
                                )
                            } else {
                                let v288: i32 = (v281) - (v282);
                                (
                                    if (v288) >= (v275) {
                                        v280.clone()
                                    } else {
                                        let v291: string = v272[v288].clone();
                                        let v300: string = if contains(v291.clone(), string("://"))
                                        {
                                            v283.clone()
                                        } else {
                                            v291
                                        };
                                        if (v288) == ((v275) - 1_i32) {
                                            concat(new_array(&[
                                                v280.clone(),
                                                v300.clone(),
                                                string("\n"),
                                                v283.clone(),
                                            ]))
                                        } else {
                                            sprintf!("{}{}\n{}\n", v280, v300, v283)
                                        }
                                    },
                                    (v281) + 1_i32,
                                    v282,
                                )
                            };
                            let v311: i32 = (v279) + 1_i32;
                            v277.l0.set(v311);
                            v277.l1.set(patternInput_2.0.clone());
                            v277.l2.set(patternInput_2.1.clone());
                            v277.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v277.l1.get().clone();
                            let matchValue_4: i32 = v277.l2.get().clone();
                            let matchValue_5: i32 = v277.l3.get().clone();
                            let v312: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v312.clone()).unwrap();
                            {
                                let v627: () = {
                                    Documents::closure79(v2, v261, v312.clone(), ());
                                    ()
                                };
                                Documents::US37::US37_0(v261, v312)
                            }
                        }
                    }
                }
            }
        }
        pub fn method187(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v3.clone(), string("result"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v147: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v166: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method186(
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
            let v10: string = Documents::method187(v8, v9);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.files_fn / error"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure80(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v59,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method186(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method11(),
                    v1_1,
                    v0_1,
                );
                let v141: () = {
                    v17();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure77(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US34 {
            let patternInput: (string, string) = Documents::method165(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if (Documents::method28(v6.clone())) == false {
                true
            } else {
                (Documents::method28(v7.clone())) == false
            } {
                false
            } else {
                let v13: string = Documents::method36(v6.clone());
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
                            let _let__v127: LrcPtr<dyn IEnumerable_1<string>> =
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
                            let v136: string = Documents::method166();
                            let v143: string = join(
                                if (v136.clone()) == string("\n") {
                                    Documents::method63(v136.clone())
                                } else {
                                    v136
                                },
                                toArray_1(_let__v127),
                            );
                            let v150 = Documents::method67();
                            let v154: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v143).map_err(|x| v150(x));
                            let v166 = Documents::method167();
                            let v167 = Documents::method168();
                            let v169: Documents::US35 = match v154 {
                                Ok(x) => v166(x),
                                Err(e) => v167(e),
                            };
                            let v178: string = match &v169 {
                                Documents::US35::US35_0(v169_0_0) => v169_0_0.clone(),
                                Documents::US35::US35_1(v169_1_0) => panic!(
                                    "{}",
                                    sprintf!("resultm.get / Error x: {}", v169_1_0.clone()),
                                ),
                            };
                            let v179: string = Documents::method36(v7.clone());
                            let v181: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v179);
                            let v185: std::fs::File = v181.unwrap();
                            let v198: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v185);
                            let v200: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v198);
                            let v202: bool = true;
                            let mut v200 = v200;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v205: sha2::Sha256 = result;
                                let v207: bool = true;
                                let mut v205 = v205;
                                let v209: usize = 0_i32 as usize;
                                let v213: _ = [0_u8; 1024];
                                let v215: bool = true;
                                loop {
                                    // rust.loop;
                                    let v217: bool = true;
                                    let mut v213 = v213;
                                    let v219: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v200, &mut v213);
                                    let v232: usize = v219.unwrap();
                                    if (v232) == (v209) {
                                        let v240: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v242: usize = v232;
                                        let v259: &_ = if (v242) == (v213.len()) {
                                            &v213[v209..]
                                        } else {
                                            &v213[v209..v242]
                                        };
                                        sha2::Digest::update(&mut v205, v259);
                                        {
                                            let v262: bool = true;
                                        } // rust.loop;
                                        let v264: bool = true;
                                    } // rust.loop;
                                    let v266: bool = true;
                                } // rust.loop;
                                let v268: bool = true;
                                {
                                    // rust.loop;
                                    let v270: bool = true;
                                    {
                                        // rust.loop;
                                        let v272: &[u8] = &sha2::Digest::finalize(v205);
                                        let v274: Vec<u8> =
                                            v272.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v276: bool = true;
                                        let _vec_map: Vec<_> = v274
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v278: u8 = x;
                                                let v280: std::string::String =
                                                    format!("{:02x}", v278);
                                                let v282: string =
                                                    fable_library_rust::String_::fromString(v280);
                                                let v284: bool = true;
                                                v282
                                            })
                                            .collect::<Vec<_>>();
                                        let v286: Vec<string> = _vec_map;
                                        let v288: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v286.clone(),
                                            );
                                        let _let__v293: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v288 = v288.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v288 = v288.clone();
                                                            move |i_1: i32| v288[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v288.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v302: string = Documents::method166();
                                        let v309: string = join(
                                            if (v302.clone()) == string("\n") {
                                                Documents::method63(v302.clone())
                                            } else {
                                                v302
                                            },
                                            toArray_1(_let__v293),
                                        );
                                        let v316 = Documents::method67();
                                        let v320: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v309).map_err(|x| v316(x));
                                        let v332 = Documents::method167();
                                        let v333 = Documents::method168();
                                        let v335: Documents::US35 = match v320 {
                                            Ok(x) => v332(x),
                                            Err(e) => v333(e),
                                        };
                                        (v178)
                                            == (match &v335 {
                                                Documents::US35::US35_0(v335_0_0) => {
                                                    v335_0_0.clone()
                                                }
                                                Documents::US35::US35_1(v335_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Error x: {}",
                                                        v335_1_0.clone()
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
                Documents::US34::US34_1
            } else {
                let v348: Documents::US37 = Documents::method178(v2, v3, v6.clone(), v4);
                match &v348 {
                    Documents::US37::US37_0(v348_0_0, v348_0_1) => {
                        let v350: string = v348_0_1.clone();
                        let v349: i32 = v348_0_0.clone();
                        if (v349) != 0_i32 {
                            let v668: () = {
                                Documents::closure80(v350.clone(), v349, ());
                                ()
                            };
                            Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v350)),
                            ))
                        } else {
                            if Documents::method28(v6.clone()) {
                                Documents::method171(v7.clone(), v6.clone())
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
                            Documents::US34::US34_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US37::US37_1(v348_1_0, v348_1_1) => {
                        Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v348_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure76(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US34> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure77(
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
        pub fn method190(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v131: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v148: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v165: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v184: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v201: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v218: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v237: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method189(
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
            let v11: string = Documents::method190(v8, v9, v10);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.crowbook / result contains ERROR"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure83(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method189(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method33(),
                    v2,
                    v0_1,
                    v1_1,
                );
                let v142: () = {
                    v18();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method188(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US37 {
            let v61: string = if string("html") == (v4.clone()) {
                string(
                    "--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                )
            } else {
                if string("pdf") == (v4.clone()) {
                    append(
                        (append(
                            string(
                                "--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\"",
                            ),
                            (if (v0_1) == false {
                                string("")
                            } else {
                                string(
                                    " tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13",
                                )
                            }),
                        )),
                        string(
                            " rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                        ),
                    )
                } else {
                    if string("epub") == (v4.clone()) {
                        string(
                            "--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                        )
                    } else {
                        string("")
                    }
                }
            };
            let patternInput: (i32, string) = Documents::method81(
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
                true,
            );
            let v89: string = patternInput.1.clone();
            let v88: i32 = patternInput.0.clone();
            if (contains(v89.clone(), string("ERROR"))) == false {
                Documents::US37::US37_0(v88, v89.clone())
            } else {
                let v411: () = {
                    Documents::closure83(v1_1, v89.clone(), v88, ());
                    ()
                };
                Documents::US37::US37_1(v88, v89)
            }
        }
        pub fn closure82(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US34 {
            let patternInput: (string, string) = Documents::method165(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method28(v5.clone())) == false {
                true
            } else {
                (Documents::method28(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method36(v5.clone());
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
                            let _let__v126: LrcPtr<dyn IEnumerable_1<string>> =
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
                            let v135: string = Documents::method166();
                            let v142: string = join(
                                if (v135.clone()) == string("\n") {
                                    Documents::method63(v135.clone())
                                } else {
                                    v135
                                },
                                toArray_1(_let__v126),
                            );
                            let v149 = Documents::method67();
                            let v153: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v142).map_err(|x| v149(x));
                            let v165 = Documents::method167();
                            let v166 = Documents::method168();
                            let v168: Documents::US35 = match v153 {
                                Ok(x) => v165(x),
                                Err(e) => v166(e),
                            };
                            let v177: string = match &v168 {
                                Documents::US35::US35_0(v168_0_0) => v168_0_0.clone(),
                                Documents::US35::US35_1(v168_1_0) => panic!(
                                    "{}",
                                    sprintf!("resultm.get / Error x: {}", v168_1_0.clone()),
                                ),
                            };
                            let v178: string = Documents::method36(v6.clone());
                            let v180: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v178);
                            let v184: std::fs::File = v180.unwrap();
                            let v197: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v184);
                            let v199: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v197);
                            let v201: bool = true;
                            let mut v199 = v199;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v204: sha2::Sha256 = result;
                                let v206: bool = true;
                                let mut v204 = v204;
                                let v208: usize = 0_i32 as usize;
                                let v212: _ = [0_u8; 1024];
                                let v214: bool = true;
                                loop {
                                    // rust.loop;
                                    let v216: bool = true;
                                    let mut v212 = v212;
                                    let v218: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v199, &mut v212);
                                    let v231: usize = v218.unwrap();
                                    if (v231) == (v208) {
                                        let v239: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v241: usize = v231;
                                        let v258: &_ = if (v241) == (v212.len()) {
                                            &v212[v208..]
                                        } else {
                                            &v212[v208..v241]
                                        };
                                        sha2::Digest::update(&mut v204, v258);
                                        {
                                            let v261: bool = true;
                                        } // rust.loop;
                                        let v263: bool = true;
                                    } // rust.loop;
                                    let v265: bool = true;
                                } // rust.loop;
                                let v267: bool = true;
                                {
                                    // rust.loop;
                                    let v269: bool = true;
                                    {
                                        // rust.loop;
                                        let v271: &[u8] = &sha2::Digest::finalize(v204);
                                        let v273: Vec<u8> =
                                            v271.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v275: bool = true;
                                        let _vec_map: Vec<_> = v273
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v277: u8 = x;
                                                let v279: std::string::String =
                                                    format!("{:02x}", v277);
                                                let v281: string =
                                                    fable_library_rust::String_::fromString(v279);
                                                let v283: bool = true;
                                                v281
                                            })
                                            .collect::<Vec<_>>();
                                        let v285: Vec<string> = _vec_map;
                                        let v287: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v285.clone(),
                                            );
                                        let _let__v292: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v287 = v287.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v287 = v287.clone();
                                                            move |i_1: i32| v287[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v287.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v301: string = Documents::method166();
                                        let v308: string = join(
                                            if (v301.clone()) == string("\n") {
                                                Documents::method63(v301.clone())
                                            } else {
                                                v301
                                            },
                                            toArray_1(_let__v292),
                                        );
                                        let v315 = Documents::method67();
                                        let v319: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v308).map_err(|x| v315(x));
                                        let v331 = Documents::method167();
                                        let v332 = Documents::method168();
                                        let v334: Documents::US35 = match v319 {
                                            Ok(x) => v331(x),
                                            Err(e) => v332(e),
                                        };
                                        (v177)
                                            == (match &v334 {
                                                Documents::US35::US35_0(v334_0_0) => {
                                                    v334_0_0.clone()
                                                }
                                                Documents::US35::US35_1(v334_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Error x: {}",
                                                        v334_1_0.clone()
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
                Documents::US34::US34_1
            } else {
                let v347: Documents::US37 = Documents::method188(v2, v5.clone(), v3, v1_1, v4);
                match &v347 {
                    Documents::US37::US37_0(v347_0_0, v347_0_1) => {
                        let v349: string = v347_0_1.clone();
                        let v348: i32 = v347_0_0.clone();
                        if (v348) != 0_i32 {
                            let v667: () = {
                                Documents::closure80(v349.clone(), v348, ());
                                ()
                            };
                            Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v349)),
                            ))
                        } else {
                            if Documents::method28(v5.clone()) {
                                Documents::method171(v6.clone(), v5.clone())
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
                            Documents::US34::US34_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US37::US37_1(v347_1_0, v347_1_1) => {
                        Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v347_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure81(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US34> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure82(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method192(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("output_path"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v91: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v3.clone(), string("output_cache_path"), ());
                ()
            };
            let v127: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v144: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method191(
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
            let v10: string = Documents::method192(v8, v9);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run / par_map / files\' = [] / listm.iter"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure84(v0_1: string, v1_1: string, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v59,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method191(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method11(),
                    v1_1,
                    v0_1,
                );
                let v141: () = {
                    v17();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method193(
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
                    Documents::method193(
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
        pub fn closure86(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: LrcPtr<Documents::UH4>,
        ) -> LrcPtr<Documents::UH4> {
            LrcPtr::new(Documents::UH4::UH4_1(v0_1, v1_1))
        }
        pub fn closure85(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH5>,
        ) -> Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH4>| Documents::closure86(v0_1.clone(), v)
            })
        }
        pub fn method194()
        -> Func1<LrcPtr<Documents::UH5>, Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH5>| Documents::closure85((), v))
        }
        pub fn method196(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US34>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US34>>,
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
                    Documents::method196(
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
        pub fn closure87(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US34>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US34 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US34::US34_0(v4_0_0) => Some(
                    match &v4 {
                        Documents::US34::US34_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method197(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method198(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method195(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH4>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method195: loop {
                break '_method195 (match v0_1.get().clone().as_ref() {
                    Documents::UH4::UH4_0 => v1_1.get().clone(),
                    Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => {
                        let v20 = toArray(Documents::method196(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH4::UH4_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US34>>,
                            )>(),
                        ));
                        let v24 = v20.to_vec();
                        let v26 = rayon::iter::IntoParallelIterator::into_par_iter(v24);
                        let v29 = rayon::iter::ParallelIterator::map(v26, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US34>>,
                                )| {
                                    Documents::closure87((), arg10_0040)
                                },
                            )(x)
                        });
                        let v32: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method197(rayon::iter::ParallelIterator::collect(v29));
                        let v33: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method198(v1_1.get().clone());
                        let v35: bool = true;
                        let mut v33 = v33;
                        let v37: bool = true;
                        v33.extend(v32);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH4::UH4_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v33;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method195;
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
            let v6: string = Documents::method59(v5);
            let v13: &str = &*v6.clone();
            let v49: std::string::String = String::from(v13);
            let v85: std::path::PathBuf = std::path::PathBuf::from(v49);
            let v121: std::path::Display = v85.display();
            let v157: std::string::String = format!("{}", v121);
            let v194: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v157),
                        v3.clone(),
                        Documents::method79(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v195: string = Documents::method36(v6);
            let v197: string = Documents::method80(Documents::method26(v2.clone(), v194.clone()));
            let patternInput: (i32, string) = Documents::method81(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v197.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
                true,
            );
            let v223: string = patternInput.1.clone();
            let v222: i32 = patternInput.0.clone();
            let v225: string = Documents::method80(Documents::method26(v3.clone(), v194.clone()));
            let patternInput_1: (i32, string) = Documents::method81(
                concat(new_array(&[
                    string("git hash-object \""),
                    v225.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
                true,
            );
            let v251: string = patternInput_1.1.clone();
            let v250: i32 = patternInput_1.0.clone();
            let v253: string = Documents::method80(Documents::method26(v4.clone(), v194.clone()));
            let v255: string =
                (Documents::method165(string("hangul.md"), v225.clone(), v4.clone()))
                    .0
                    .clone();
            let v1938: LrcPtr<Documents::UH4> = if contains(v223.clone(), v251.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v268: string = Documents::method36(v225.clone());
                let v270: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v268);
                let v274: std::fs::File = v270.unwrap();
                let v287: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v274);
                let v289: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v287);
                let v291: bool = true;
                let mut v289 = v289;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v294: sha2::Sha256 = result;
                    let v296: bool = true;
                    let mut v294 = v294;
                    let v298: usize = 0_i32 as usize;
                    let v302: _ = [0_u8; 1024];
                    let v304: bool = true;
                    loop {
                        // rust.loop;
                        let v306: bool = true;
                        let mut v302 = v302;
                        let v308: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v289, &mut v302);
                        let v321: usize = v308.unwrap();
                        if (v321) == (v298) {
                            let v329: bool = true;
                            break;
                            ()
                        }
                        {
                            let v331: usize = v321;
                            let v348: &_ = if (v331) == (v302.len()) {
                                &v302[v298..]
                            } else {
                                &v302[v298..v331]
                            };
                            sha2::Digest::update(&mut v294, v348);
                            {
                                let v351: bool = true;
                            } // rust.loop;
                            let v353: bool = true;
                        } // rust.loop;
                        let v355: bool = true;
                    } // rust.loop;
                    let v357: bool = true;
                    {
                        // rust.loop;
                        let v359: bool = true;
                        {
                            // rust.loop;
                            let v361: &[u8] = &sha2::Digest::finalize(v294);
                            let v363: Vec<u8> = v361.iter().map(|x| *x).collect::<Vec<_>>();
                            let v365: bool = true;
                            let _vec_map: Vec<_> = v363
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v367: u8 = x;
                                    let v369: std::string::String = format!("{:02x}", v367);
                                    let v371: string =
                                        fable_library_rust::String_::fromString(v369);
                                    let v373: bool = true;
                                    v371
                                })
                                .collect::<Vec<_>>();
                            let v375: Vec<string> = _vec_map;
                            let v377: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v375.clone());
                            let _let__v382: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v377 = v377.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v377 = v377.clone();
                                                move |i: i32| v377[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v377.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v391: string = Documents::method166();
                            let v398: string = join(
                                if (v391.clone()) == string("\n") {
                                    Documents::method63(v391.clone())
                                } else {
                                    v391
                                },
                                toArray_1(_let__v382),
                            );
                            let v405 = Documents::method67();
                            let v409: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v398).map_err(|x| v405(x));
                            let v421 = Documents::method167();
                            let v422 = Documents::method168();
                            let v424: Documents::US35 = match v409 {
                                Ok(x) => v421(x),
                                Err(e) => v422(e),
                            };
                            let v433: string = match &v424 {
                                Documents::US35::US35_0(v424_0_0) => v424_0_0.clone(),
                                Documents::US35::US35_1(v424_1_0) => panic!(
                                    "{}",
                                    sprintf!("resultm.get / Error x: {}", v424_1_0.clone()),
                                ),
                            };
                            let v600: Documents::US5 = if (Documents::method28(v253.clone()))
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v437: string = Documents::method36(v253.clone());
                                let v439: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v437);
                                let v443: std::fs::File = v439.unwrap();
                                let v456: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v443);
                                let v458: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v456);
                                let v460: bool = true;
                                let mut v458 = v458;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v463: sha2::Sha256 = result;
                                    let v465: bool = true;
                                    let mut v463 = v463;
                                    let v467: usize = 0_i32 as usize;
                                    let v471: _ = [0_u8; 1024];
                                    let v473: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v475: bool = true;
                                        let mut v471 = v471;
                                        let v477: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v458, &mut v471);
                                        let v490: usize = v477.unwrap();
                                        if (v490) == (v467) {
                                            let v498: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v500: usize = v490;
                                            let v517: &_ = if (v500) == (v471.len()) {
                                                &v471[v467..]
                                            } else {
                                                &v471[v467..v500]
                                            };
                                            sha2::Digest::update(&mut v463, v517);
                                            {
                                                let v520: bool = true;
                                            } // rust.loop;
                                            let v522: bool = true;
                                        } // rust.loop;
                                        let v524: bool = true;
                                    } // rust.loop;
                                    let v526: bool = true;
                                    {
                                        // rust.loop;
                                        let v528: bool = true;
                                        {
                                            // rust.loop;
                                            let v530: &[u8] = &sha2::Digest::finalize(v463);
                                            let v532: Vec<u8> =
                                                v530.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v534: bool = true;
                                            let _vec_map: Vec<_> = v532
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v536: u8 = x;
                                                    let v538: std::string::String =
                                                        format!("{:02x}", v536);
                                                    let v540: string =
                                                        fable_library_rust::String_::fromString(
                                                            v538,
                                                        );
                                                    let v542: bool = true;
                                                    v540
                                                })
                                                .collect::<Vec<_>>();
                                            let v544: Vec<string> = _vec_map;
                                            let v546: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(
                                                    v544.clone(),
                                                );
                                            let _let__v551: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v546 = v546.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v546 = v546.clone();
                                                                move |i_1: i32| v546[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                (get_Count(v546.clone())) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v560: string = Documents::method166();
                                            let v567: string = join(
                                                if (v560.clone()) == string("\n") {
                                                    Documents::method63(v560.clone())
                                                } else {
                                                    v560
                                                },
                                                toArray_1(_let__v551),
                                            );
                                            let v574 = Documents::method67();
                                            let v578: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v567)
                                                    .map_err(|x| v574(x));
                                            let v590 = Documents::method167();
                                            let v591 = Documents::method168();
                                            let v593: Documents::US35 = match v578 {
                                                Ok(x) => v590(x),
                                                Err(e) => v591(e),
                                            };
                                            match &v593 {
                                                Documents::US35::US35_0(v593_0_0) => {
                                                    Documents::US5::US5_0(v593_0_0.clone())
                                                }
                                                _ => Documents::US5::US5_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US5::US5_0(v600_0_0) = &v600 {
                                if (v433.clone()) == (v600_0_0.clone()) {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v925: () = {
                                        Documents::closure71(
                                            v194.clone(),
                                            v195.clone(),
                                            v197.clone(),
                                            v223.clone(),
                                            v222,
                                            v225.clone(),
                                            v251.clone(),
                                            v250,
                                            v253.clone(),
                                            v433.clone(),
                                            v600.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method171(v253.clone(), v225.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v225.clone(),
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
                                                            Documents::closure76(
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
                                                v225.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure81(
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
                                                    v225.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure81(
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
                                                        v225.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure81(
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
                                                            v255.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure81(
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
                                                                v255.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure81(
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
                                                                    v255.clone(),
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
                                                                                                                                                                                                                                                                                                                                                               Documents::closure81(v4.clone(),
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
                                let v1592: () = {
                                    Documents::closure71(
                                        v194,
                                        v195.clone(),
                                        v197,
                                        v223,
                                        v222,
                                        v225.clone(),
                                        v251,
                                        v250,
                                        v253.clone(),
                                        v433,
                                        v600.clone(),
                                        (),
                                    );
                                    ()
                                };
                                Documents::method171(v253, v225.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v225.clone(),
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
                                                        Documents::closure76(
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
                                            v225.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_8: string| {
                                                            Documents::closure81(
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
                                                v225.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_9: string| {
                                                                Documents::closure81(
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
                                                    v225.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_10: string| {
                                                                    Documents::closure81(
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
                                                        v255.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_11: string| {
                                                                        Documents::closure81(
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
                                                            v255.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_12: string| {
                                                                            Documents::closure81(
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
                                                                v255.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_13: string| {
                                                                                Documents::closure81(
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
            let v6426: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method193(
                if (if let Documents::UH4::UH4_0 = v1938.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v1938
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method165(string("epub"), v255.clone(), v4.clone());
                    let v1943: string = patternInput_3.1.clone();
                    let v1942: string = patternInput_3.0.clone();
                    let v2581: LrcPtr<Documents::UH5> = if if Documents::method28(v1942.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1943.clone())) == false {
                            true
                        } else {
                            let v2260: () = {
                                Documents::closure84(v1943.clone(), v1942.clone(), ());
                                ()
                            };
                            Documents::method171(v1942, v1943);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v255.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_14: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_14)
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
                        Documents::method165(string("pdf"), v255.clone(), v4.clone());
                    let v2584: string = patternInput_4.1.clone();
                    let v2583: string = patternInput_4.0.clone();
                    let v3220: LrcPtr<Documents::UH5> = if if Documents::method28(v2583.clone()) {
                        true
                    } else {
                        if (Documents::method28(v2584.clone())) == false {
                            true
                        } else {
                            let v2901: () = {
                                Documents::closure84(v2584.clone(), v2583.clone(), ());
                                ()
                            };
                            Documents::method171(v2583, v2584);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v255.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_15: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v2581.clone(),
                        ))
                    } else {
                        v2581
                    };
                    let patternInput_5: (string, string) =
                        Documents::method165(string("html"), v255.clone(), v4.clone());
                    let v3223: string = patternInput_5.1.clone();
                    let v3222: string = patternInput_5.0.clone();
                    let v3859: LrcPtr<Documents::UH5> = if if Documents::method28(v3222.clone()) {
                        true
                    } else {
                        if (Documents::method28(v3223.clone())) == false {
                            true
                        } else {
                            let v3540: () = {
                                Documents::closure84(v3223.clone(), v3222.clone(), ());
                                ()
                            };
                            Documents::method171(v3222, v3223);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v255,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_16: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v3220.clone(),
                        ))
                    } else {
                        v3220
                    };
                    let patternInput_6: (string, string) =
                        Documents::method165(string("epub"), v225.clone(), v4.clone());
                    let v3861: string = patternInput_6.1.clone();
                    let v3860: string = patternInput_6.0.clone();
                    let v4497: LrcPtr<Documents::UH5> = if if Documents::method28(v3860.clone()) {
                        true
                    } else {
                        if (Documents::method28(v3861.clone())) == false {
                            true
                        } else {
                            let v4178: () = {
                                Documents::closure84(v3861.clone(), v3860.clone(), ());
                                ()
                            };
                            Documents::method171(v3860, v3861);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v225.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_17: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v3859.clone(),
                        ))
                    } else {
                        v3859
                    };
                    let patternInput_7: (string, string) =
                        Documents::method165(string("pdf"), v225.clone(), v4.clone());
                    let v4499: string = patternInput_7.1.clone();
                    let v4498: string = patternInput_7.0.clone();
                    let v5135: LrcPtr<Documents::UH5> = if if Documents::method28(v4498.clone()) {
                        true
                    } else {
                        if (Documents::method28(v4499.clone())) == false {
                            true
                        } else {
                            let v4816: () = {
                                Documents::closure84(v4499.clone(), v4498.clone(), ());
                                ()
                            };
                            Documents::method171(v4498, v4499);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v225.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_18: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v4497.clone(),
                        ))
                    } else {
                        v4497
                    };
                    let patternInput_8: (string, string) =
                        Documents::method165(string("html"), v225.clone(), v4.clone());
                    let v5137: string = patternInput_8.1.clone();
                    let v5136: string = patternInput_8.0.clone();
                    let v5773: LrcPtr<Documents::UH5> = if if Documents::method28(v5136.clone()) {
                        true
                    } else {
                        if (Documents::method28(v5137.clone())) == false {
                            true
                        } else {
                            let v5454: () = {
                                Documents::closure84(v5137.clone(), v5136.clone(), ());
                                ()
                            };
                            Documents::method171(v5136, v5137);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v225.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_19: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v5135.clone(),
                        ))
                    } else {
                        v5135
                    };
                    let patternInput_9: (string, string) =
                        Documents::method165(string("hangul.md"), v225.clone(), v4.clone());
                    let v5775: string = patternInput_9.1.clone();
                    let v5774: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method28(v5774.clone()) {
                            true
                        } else {
                            if (Documents::method28(v5775.clone())) == false {
                                true
                            } else {
                                let v6092: () = {
                                    Documents::closure84(v5775.clone(), v5774.clone(), ());
                                    ()
                                };
                                Documents::method171(v5774, v5775);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v225,
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
                                                Documents::closure76(
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
                            v5773,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v6430: Vec<LrcPtr<Documents::UH5>> = v6426.to_vec();
            let v6433: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v6437: List<LrcPtr<Documents::UH5>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v6430.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v195,
                Documents::method195(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH5>, b1: LrcPtr<Documents::UH4>| {
                                (Documents::method194())(b0)(b1)
                            },
                        ),
                        v6437,
                        LrcPtr::new(Documents::UH4::UH4_0),
                    ),
                    v6433,
                ),
            )))
        }
        pub fn method23(
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
            let v5: Documents::US5 = Documents::method25(Documents::method24());
            let v11: Documents::US5 = match &v5 {
                Documents::US5::US5_0(v5_0_0) => Documents::US5::US5_0(
                    match &v5 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method25(string(
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
                _ => Documents::method25(string("/workspaces")),
            };
            let v21: string = match &v17 {
                Documents::US5::US5_0(v17_0_0) => match &v17 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v36: string = Documents::method26(
                if string("deps") == (Documents::method45(v21.clone())) {
                    let v29: Documents::US5 =
                        Documents::method25(Documents::method31(v21.clone()).clone().unwrap());
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
            let v37: string = Documents::method59(v3);
            let v38: string = Documents::method59(v2);
            let v39: string = Documents::method59(v1_1);
            let v353: () = {
                Documents::closure24(v0_1.clone(), v37.clone(), v38.clone(), v39.clone(), ());
                ()
            };
            let v669: bool = true;
            let __future_init = Box::pin(
                /*;
                let v671: bool = */
                async move {
                    /*;
                    let v673: bool = */
                    ();
                    let v675: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v38.clone());
                    let v678: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v675, move |x| {
                            Func1::new(move |v: async_walkdir::DirEntry| {
                                Documents::closure25((), v)
                            })(x)
                        });
                    let v679 = Documents::method70();
                    let v681 = futures::stream::StreamExt::filter_map(v678, |x| async { v679(x) });
                    let v683: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v681));
                    let v685: Vec<string> = v683.await;
                    let v1001: () = {
                        Documents::closure34(v685.clone(), ());
                        ()
                    };
                    let v1319: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v685);
                    let v1322: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v1319, |x| {
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
                    let v1324: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v1322);
                    let v1331: string = string("}");
                    let v1336: bool = true;
                    let _fix_closure_v1333 = Ok::<
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
                    >(v1324);
                    let v1342: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v1333 "), (v1331))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v1343: bool = true;
                    _fix_closure_v1333
                },
            ); // rust.fix_closure';
            let v1345 = __future_init;
            v1345
        }
        pub fn closure88(
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
        ) -> Documents::US38 {
            Documents::US38::US38_0(v0_1)
        }
        pub fn method199() -> Func1<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            Documents::US38,
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
                >| Documents::closure88((), v),
            )
        }
        pub fn closure89(unitVar: (), v0_1: std::string::String) -> Documents::US38 {
            Documents::US38::US38_1(v0_1)
        }
        pub fn method200() -> Func1<std::string::String, Documents::US38> {
            Func1::new(move |v: std::string::String| Documents::closure89((), v))
        }
        pub fn method201(
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
            let v9: string = Documents::method76(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure90(v0_1: std::string::String, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method201(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method74(),
                    v0_1,
                );
                let v140: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method203(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("result_len"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method202(
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
            let v9: string = Documents::method203(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure91(
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
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v58,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method202(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method11(),
                    v0_1.len(),
                );
                let v142: () = {
                    v16();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v17: () = {
                Documents::closure2((), ());
                ()
            };
            let v345: () = {
                Documents::closure5(v0_1, ());
                ()
            };
            let v660: clap::Command = Documents::method0();
            let v662: clap::ArgMatches = clap::Command::get_matches(v660);
            let v663: string = Documents::method18();
            let v670: &str = &*v663;
            let v701: Option<std::string::String> =
                clap::ArgMatches::get_one(&v662.clone(), v670).cloned();
            let v726: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v701));
            let v733: std::string::String = match &v726 {
                Documents::US7::US7_0(v726_0_0) => match &v726 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v735: string = fable_library_rust::String_::fromString(v733);
            let v736: string = Documents::method20();
            let v743: &str = &*v736;
            let v774: Option<std::string::String> =
                clap::ArgMatches::get_one(&v662.clone(), v743).cloned();
            let v799: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v774));
            let v806: std::string::String = match &v799 {
                Documents::US7::US7_0(v799_0_0) => match &v799 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v808: string = fable_library_rust::String_::fromString(v806);
            let v809: string = Documents::method21();
            let v816: &str = &*v809;
            let v847: Option<std::string::String> =
                clap::ArgMatches::get_one(&v662.clone(), v816).cloned();
            let v872: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v847));
            let v879: std::string::String = match &v872 {
                Documents::US7::US7_0(v872_0_0) => match &v872 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v881: string = fable_library_rust::String_::fromString(v879);
            let v882: string = Documents::method22();
            let v889: &str = &*v882;
            let v920: Option<std::string::String> = clap::ArgMatches::get_one(&v662, v889).cloned();
            let v945: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v920));
            let v952: std::string::String = match &v945 {
                Documents::US7::US7_0(v945_0_0) => match &v945 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v955: std::pin::Pin<
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
            > = Documents::method23(
                fable_library_rust::String_::fromString(v952),
                v881,
                v808,
                v735,
            );
            let v957: Result<
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
            > = futures::executor::block_on(v955);
            let v958 = Documents::method199();
            let v959 = Documents::method200();
            let v961: Documents::US38 = match &v957 {
                Err(v957_1_0) => v959(v957_1_0.clone()),
                Ok(v957_0_0) => v958(v957_0_0.clone()),
            };
            match &v961 {
                Documents::US38::US38_0(v961_0_0) => {
                    let v1280: () = {
                        Documents::closure91(v961_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US38::US38_1(v961_1_0) => {
                    let v1911: () = {
                        Documents::closure90(v961_1_0.clone(), ());
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
