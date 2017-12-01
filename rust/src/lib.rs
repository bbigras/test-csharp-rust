extern crate libc;

use libc::c_char;

#[no_mangle]
pub extern "C" fn test(v1: *const c_char) {
    println!("test");
}
