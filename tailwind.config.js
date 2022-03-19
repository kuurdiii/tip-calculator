module.exports = {
    content: ["./**/*.{html,razor,cshtml}"],
    theme: {
      extend: {},
    },
    plugins: [
        require('@tailwindcss/forms'),
    ],
  };