import { fileURLToPath, URL } from "node:url";

import { defineConfig } from "vite";
import vue from "@vitejs/plugin-vue";

const proxyCalls = ["/api", "/signin-oidc", "/signout-callback-oidc", "/healthz"];

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue()],
  resolve: {
    alias: {
      "@": fileURLToPath(new URL("./src", import.meta.url))
    }
  },
  server: {
    proxy: Object.fromEntries(
      proxyCalls.map((key) => [
        key,
        {
          target: "http://localhost:62230",
          secure: false
        }
      ])
    )
  },
  build: {
    assetsInlineLimit: 0
  }
});
