$.validator.methods.number = function (value, number) {
    return this.optional(element) || /^(?:-?\d+|-?\d{1,3}(?:.\d{3})+)?(?:\,\d+)?$/.test(value);
}
