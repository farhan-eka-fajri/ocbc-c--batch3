module.exports = {

    // purge: {
    //     content: [
    //         './src/**/*.{html,ts}',
    //     ]
    // },
    // darkMode: 'class', // or 'media' or 'class'
    // theme: {
    //     extend: {},
    // },
    // variants: {
    //     extend: {},
    // },
    plugins: [
        require('@tailwindcss/typography'),
        require('daisyui')
    ],
    daisyui: {
        styled: true,
        themes: ["retro"],
        base: true,
        utils: true,
        logs: true,
        rtl: false,
        prefix: "",
      }, 
}