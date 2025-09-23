import {
  type RouteConfig,
  route,
} from "@react-router/dev/routes";

export default [
  route("home", "./pages/file.tsx"),
  // pattern ^           ^ module file
] satisfies RouteConfig;
